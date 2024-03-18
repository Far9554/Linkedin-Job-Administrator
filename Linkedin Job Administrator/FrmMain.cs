using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Linkedin_Job_Administrator.CLASSES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;

//--allports - 50: #f1f9fe;
//--allports - 100: #e2f3fc;
//--allports - 200: #bee7f9;
//--allports - 300: #85d3f4;
//--allports - 400: #44bdec;
//--allports - 500: #1ba6dc;
//--allports - 600: #0e85bb;
//--allports - 700: #0e76a8;
//--allports - 800: #0f5a7d;
//--allports - 900: #124b68;
//--allports - 950: #0c3045;

namespace Linkedin_Job_Administrator
{
    public partial class FrmMain : Form
    {
        private List<Oferta> ofertas = new List<Oferta>();

        public FrmMain()
        {
            InitializeComponent();
            GmailAPIManager.InicializarGmailService();
            InicializarDataGridView();
        }

        private void InicializarDataGridView()
        {
            progressBar.Visible = false;

            // Configuración de columnas para el DataGridView
            _dataTable.AutoGenerateColumns = true; // Permitir que las columnas se generen automáticamente
            _dataTable.DataSource = ofertas;

            tpBefore.Value = DateTime.Now;
            tpAfter.Value = DateTime.Now.AddMonths(-6);

            // Suscribir al evento CellContentClick
            _dataTable.CellContentClick += DataGridView_CellContentClick;
        }

        private void StyleDataGridView()
        {
            if (_dataTable != null && _dataTable.Columns.Count >= 4)
            {
                _dataTable.Columns[0].Width = 120;
                _dataTable.Columns[2].Width = 75;
                _dataTable.Columns[3].Width = 90;
            }
        }

        private async void ObtenerCorreosButton_Click(object sender, EventArgs e)
        {
            btCheck.Enabled = false;
            btSearch.Enabled = false;
            progressBar.Visible = true;
            progressBar.Value = 0;

            // Limpiar DataTable
            ofertas.Clear();
            _dataTable.DataSource = null;
            _dataTable.Enabled = false;

            int maxResults = (int)udMaxCheck.Value;

            // Obtener correos electrónicos con el límite de resultados
            UsersResource.MessagesResource.ListRequest request = GmailAPIManager.RequestGenerator(maxResults, tpAfter.Value, tpBefore.Value);

            try
            {
                ListMessagesResponse response = await request.ExecuteAsync();
                IList<Google.Apis.Gmail.v1.Data.Message> messages = response.Messages;

                progressBar.Maximum =messages.Count;
                int progress = 0;

                // Procesar y mostrar los correos electrónicos
                foreach (var message in messages.Reverse())
                {
                    Google.Apis.Gmail.v1.Data.Message email = await GmailAPIManager.GetRequest(message).ExecuteAsync();

                    // Obtener el titulo del correo electrónico
                    string text = GmailAPIManager.GetHeaderValue(email.Payload.Headers, "Subject");

                    // Obtener la fecha del correo electrónico
                    string dateString = GmailAPIManager.GetHeaderValue(email.Payload.Headers, "Date");
                    string matchT = Regex.Match(dateString, @",\s(.+)\s+").Groups[1].Value.Trim();
                    if (DateTime.TryParseExact(matchT, "d MMM yyyy HH:mm:ss zzz", CultureInfo.InvariantCulture, DateTimeStyles.None ,out DateTime result))
                        dateString = result.ToString("d/M/yyyy");


                    if (text.Contains("your application was sent to"))
                    {
                        string[] lineas = GmailAPIManager.GetMessageBody(email).Split('\n');
                        string nombreEmpresa = lineas[3].Trim();
                        string puesto = lineas[2].Trim();
                        string link = Regex.Match(lineas[6].Trim(), @":\s(.+)$").Groups[1].Value;

                        ofertas.Insert(0, new Oferta(nombreEmpresa, puesto, 0, dateString, link));
                        //Console.WriteLine($"   YYY {nombreEmpresa} - {puesto} YYY");
                    }
                    else if (text.Contains("ha visto tu solicitud"))
                    {
                        string matchE = Regex.Match(text, @"(.+)\sha").Groups[1].Value;

                        Oferta of = ofertas.Find(x => x.CompanyName == matchE);
                        if (of != null)
                        {
                            of.JobState = State.Leido;
                            of.Date = dateString;
                        }
                        else
                        {
                            ofertas.Insert(0, new Oferta(matchE, "", State.Leido, dateString, ""));
                        }
                        //Console.WriteLine($"  ZZZ {matchE} ha visto tu CV ZZZ");
                    }
                    else if(text.Contains("Tu solicitud para el puesto de"))
                    {
                        // Realizar la búsqueda utilizando expresión regular
                        string matchP = Regex.Match(text, @"de\s(.+)\sen").Groups[1].Value; 
                        string matchE = Regex.Match(text, @"en\s(.+)$").Groups[1].Value;

                        Oferta of = ofertas.Find(x => x.CompanyName == matchE && x.JobName == matchP);
                        if (of != null)
                        {
                            of.JobState = State.Rechazado;
                            of.Date = dateString;
                        }
                        else
                        {
                            ofertas.Insert(0, new Oferta(matchE, matchP, State.Rechazado, dateString, ""));
                        }
                        //Console.WriteLine($"XXX Te han descartado en: {matchE} - {matchP} XXX");
                    }
                    else
                    {
                        Console.WriteLine(text);
                    }

                    progress++;
                    progressBar.Value = progress;

                    _dataTable.DataSource = null; // Primero, desasigna el origen de datos
                    _dataTable.DataSource = ofertas; // Luego, asigna la lista actualizada de ofertas
                }
                // Actualizar el origen de datos del DataGridView después de agregar correos electrónicos
                ResetDataView(ofertas);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al obtener correos electrónicos: " + ex.Message);
                
            }

            btCheck.Enabled = true;
            btSearch.Enabled = true;
            _dataTable.Enabled = true;
            progressBar.Visible = false;
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si el usuario hizo clic en la columna de remitente y en una celda válida
            if (e.ColumnIndex == _dataTable.Columns["LinkOferta"].Index && e.RowIndex >= 0)
            {
                // Obtener la URL del remitente de la celda
                string url = _dataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                // Abrir la URL en el navegador web predeterminado del sistema
                try
                {
                    Process.Start(url);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el enlace: " + ex.Message);
                }
            }
        }

        void SetColorsDataGrid()
        {
            foreach(DataGridViewRow row in _dataTable.Rows)
            {
                string cellValue = row.Cells[2].Value.ToString();
                if (cellValue == "Rechazado")
                    row.DefaultCellStyle.BackColor = Color.FromArgb(219, 75, 59);
                else if (cellValue == "Leido")
                    row.DefaultCellStyle.BackColor = Color.FromArgb(54, 219, 39);
                else if (row.Index % 2 == 0) 
                    row.DefaultCellStyle.BackColor = Color.FromArgb(133, 211, 244);
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if(ofertas.Count != 0)
            {
                List<Oferta> filterOfertas = ofertas;
                if (tbNombreEmpresa.Text.Length > 0)
                    filterOfertas = filterOfertas.FindAll(x => x.CompanyName.ToUpper().Contains(tbNombreEmpresa.Text.ToUpper()));
                if(tbNombrePuesto.Text.Length > 0)
                    filterOfertas = filterOfertas.FindAll(x=> x.JobName.ToUpper().Contains(tbNombrePuesto.Text.ToUpper()));
                if(cbEstadoPuesto.SelectedIndex != -1)
                    filterOfertas = filterOfertas.FindAll(x => x.JobState == (State)cbEstadoPuesto.SelectedIndex);

                ResetDataView(filterOfertas);
            }
        }

        //EXPORT BUTTONS MANAGER
        private void btXML_Click(object sender, EventArgs e) { FileManager.ExportToXML(ofertas); }
        private void btTXT_Click(object sender, EventArgs e) { FileManager.ExportToTXT(ofertas); }
        private void btCSV_Click(object sender, EventArgs e) { FileManager.ExportToCSV(ofertas); }
        private void btJSON_Click(object sender, EventArgs e) { FileManager.ExportToJSON(ofertas); }

        //IMPORT BUTTONS MANAGER
        private void ImportXML_Click(object sender, EventArgs e)
        {
            ofertas = FileManager.ImportXML();
            ResetDataView(ofertas);
        }

        private void ImportTXT_Click(object sender, EventArgs e)
        {
            ofertas = FileManager.ImportTXT();
            ResetDataView(ofertas);
        }

        private void ImportCSV_Click(object sender, EventArgs e)
        {
            ofertas = FileManager.ImportCSV();
            ResetDataView(ofertas);
        }

        private void ImportJSON_Click(object sender, EventArgs e)
        {
            ofertas = FileManager.ImportJSON();
            ResetDataView(ofertas);
        }

        void ResetDataView(List<Oferta> ofertas)
        {
            _dataTable.DataSource = null;
            _dataTable.DataSource = ofertas;
            StyleDataGridView();
            SetColorsDataGrid();
        }

        private void stadistics_Click(object sender, EventArgs e)
        {
            FrmStats stats = new FrmStats(ofertas);
            stats.TopMost = true;
            stats.Show();
        }

        private void RemoveCredentials(object sender, EventArgs e)
        {
            GmailAPIManager.RemoveCredentials();
        }

        private void ResetGmailChecking(object sender, EventArgs e)
        {
            GmailAPIManager.RemoveCredentials();
            GmailAPIManager.InicializarGmailService();
        }
    }
}
