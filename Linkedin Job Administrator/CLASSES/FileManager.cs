using Google.Apis;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using CsvHelper;
using CsvHelper.Configuration;
using Newtonsoft.Json;

namespace Linkedin_Job_Administrator.CLASSES
{
    public static class FileManager
    {
        #region XML MANAGER
        public static void ExportToXML(List<Oferta> ofertas)
        {
            SaveFileDialog saveFileDialogXml = new SaveFileDialog();
            saveFileDialogXml.Filter = "Archivos XML (*.xml)|*.xml";
            if (saveFileDialogXml.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Oferta>));
                string fileName = saveFileDialogXml.FileName;
                using (TextWriter writer = new StreamWriter(fileName))
                {
                    serializer.Serialize(writer, ofertas);
                    MessageBox.Show("Archivo XML creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public static List<Oferta> ImportXML() 
        {
            OpenFileDialog openFileDialogXml = new OpenFileDialog();
            openFileDialogXml.Filter = "Archivos XML (*.xml)|*.xml";
            if (openFileDialogXml.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Oferta>));
                using (FileStream fileStream = new FileStream(openFileDialogXml.FileName, FileMode.Open))
                {
                    return (List<Oferta>)serializer.Deserialize(fileStream);
                }
            }

            return null;
        }
        #endregion
        #region TXT MANAGER
        public static void ExportToTXT(List<Oferta> ofertas)
        {
            SaveFileDialog saveFileDialogTxt = new SaveFileDialog();
            saveFileDialogTxt.Filter = "Archivos de texto (*.txt)|*.txt";
            if (saveFileDialogTxt.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialogTxt.FileName;
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    foreach (Oferta obj in ofertas)
                    {
                        writer.WriteLine($"{obj.CompanyName}#{obj.JobName}#{obj.JobState}#{obj.Date}#{obj.LinkJob}");
                    }
                }
                MessageBox.Show("Archivo de texto creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static List<Oferta> ImportTXT()
        {
            OpenFileDialog openFileDialogTxt = new OpenFileDialog();
            openFileDialogTxt.Filter = "Archivos de texto (*.txt)|*.txt";
            if (openFileDialogTxt.ShowDialog() == DialogResult.OK)
            {
                List<Oferta> ofertas = new List<Oferta>();
                using (StreamReader reader = new StreamReader(openFileDialogTxt.FileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Parsear la línea y agregar el objeto a la lista
                        string[] o = line.Split('#');
                        State estado;
                        if (Enum.TryParse(o[2], out estado))
                            ofertas.Add(new Oferta(o[0], o[1], estado, o[3], o[4]));
                    }
                }

                return ofertas;
            }

            return null;
        }
        #endregion
        #region CSV MANAGER
        public static void ExportToCSV(List<Oferta> ofertas)
        {
            // Abrir el diálogo para guardar CSV
            SaveFileDialog saveFileDialogCsv = new SaveFileDialog();
            saveFileDialogCsv.Filter = "Archivos CSV (*.csv)|*.csv";
            if (saveFileDialogCsv.ShowDialog() == DialogResult.OK)
            {
                using (var writer = new StreamWriter(saveFileDialogCsv.FileName))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture)))
                {
                    csv.WriteRecords(ofertas);
                }
                MessageBox.Show("Archivo CSV creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static List<Oferta> ImportCSV()
        {
            // Abrir el diálogo para seleccionar archivo CSV
            OpenFileDialog openFileDialogCsv = new OpenFileDialog();
            openFileDialogCsv.Filter = "Archivos CSV (*.csv)|*.csv";
            if (openFileDialogCsv.ShowDialog() == DialogResult.OK)
            {
                using (var reader = new StreamReader(openFileDialogCsv.FileName))
                using (var csv = new CsvReader(reader, new CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture)))
                {
                    return csv.GetRecords<Oferta>().ToList();
                }
            }

            return null;
        }
        #endregion
        #region JSON MANAGER
        public static void ExportToJSON(List<Oferta> ofertas)
        {
            // Abrir el diálogo para guardar JSON
            SaveFileDialog saveFileDialogJson = new SaveFileDialog();
            saveFileDialogJson.Filter = "Archivos JSON (*.json)|*.json";
            if (saveFileDialogJson.ShowDialog() == DialogResult.OK)
            {
                string json = JsonConvert.SerializeObject(ofertas, Formatting.Indented);
                File.WriteAllText(saveFileDialogJson.FileName, json);
                MessageBox.Show("Archivo JSON creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static List<Oferta> ImportJSON()
        {
            // Abrir el diálogo para seleccionar archivo JSON
            OpenFileDialog openFileDialogJson = new OpenFileDialog();
            openFileDialogJson.Filter = "Archivos JSON (*.json)|*.json";
            if (openFileDialogJson.ShowDialog() == DialogResult.OK)
            {
                string json = File.ReadAllText(openFileDialogJson.FileName);
                return JsonConvert.DeserializeObject<List<Oferta>>(json);
            }

            return null;
        }
        #endregion
    }
}
