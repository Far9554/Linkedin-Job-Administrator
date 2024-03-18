using Linkedin_Job_Administrator.CLASSES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Linkedin_Job_Administrator
{
    public partial class FrmStats : Form
    {
        private List<Oferta> ofertas = new List<Oferta>();

        public FrmStats(List<Oferta> ofertas)
        {
            InitializeComponent();
            this.ofertas = ofertas;
            foreach (var tipo in Enum.GetValues(typeof(SeriesChartType)))
            {
                cbStyle.Items.Add(tipo.ToString());
            }
            cbStyle.SelectedIndex = 0;
            MostrarGraficoPorDiaSemana(null , null);
        }

        void MostrarGraficoPorDiaSemana(object sender, EventArgs e)
        {
            // Agrupar las ofertas por día de la semana y mes
            var ofertasPorDiaMes = ofertas.GroupBy(o => new { DayOfWeek = DateTime.Parse(o.Date).DayOfWeek, Month = DateTime.Parse(o.Date).Month })
                                           .OrderBy(g => g.Key.DayOfWeek)
                                           .Select(g => new { DayOfWeek = g.Key.DayOfWeek, Month = g.Key.Month, Count = g.Count() });

            // Limpiar el gráfico antes de agregar datos nuevos
            chart.Series.Clear();

            // Agregar series al gráfico para cada mes
            var meses = ofertas.Select(o => DateTime.Parse(o.Date).Month).Distinct().OrderBy(m => m);
            foreach (var mes in meses)
            {
                var series = chart.Series.Add($"Ofertas para el Mes {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mes)}");
                SeriesChartType tipoGrafico = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), cbStyle.SelectedItem.ToString());
                series.ChartType = SeriesChartType.Column;

                // Agregar los puntos de datos al gráfico para cada día de la semana
                foreach (var ofertaPorDiaMes in ofertasPorDiaMes.Where(o => o.Month == mes))
                {
                    series.Points.AddXY(ofertaPorDiaMes.DayOfWeek.ToString(), ofertaPorDiaMes.Count);
                }
            }
        }

        private void MostrarGraficoPorEstado(object sender, EventArgs e)
        {
            // Agrupar las ofertas por estado
            var ofertasPorEstado = ofertas.GroupBy(o => o.JobState)
                                          .Select(g => new { Estado = g.Key, Count = g.Count() });

            // Limpiar el gráfico antes de agregar datos nuevos
            chart.Series.Clear();

            // Agregar una serie al gráfico
            var series = chart.Series.Add("Ofertas por Estado");
            SeriesChartType tipoGrafico = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), cbStyle.SelectedItem.ToString());
            series.ChartType = SeriesChartType.Pie;

            // Agregar los puntos de datos al gráfico
            foreach (var ofertaPorEstado in ofertasPorEstado)
            {
                series.Points.AddXY(ofertaPorEstado.Estado.ToString(), ofertaPorEstado.Count);
            }
        }

        private void MostrarGraficoPorEmpresa(object sender, EventArgs e)
        {
            // Agrupar las ofertas por empresa
            var ofertasPorEmpresa = ofertas.GroupBy(o => o.CompanyName)
                                           .Where(g => g.Count() > 2)
                                           .Select(g => new { Empresa = g.Key, Count = g.Count() });

            // Limpiar el gráfico antes de agregar datos nuevos
            chart.Series.Clear();

            // Agregar una serie al gráfico
            var series = chart.Series.Add("Ofertas por Empresa");
            SeriesChartType tipoGrafico = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), cbStyle.SelectedItem.ToString());
            series.ChartType = SeriesChartType.Radar;

            // Agregar los puntos de datos al gráfico
            foreach (var ofertaPorEmpresa in ofertasPorEmpresa)
            {
                series.Points.AddXY(ofertaPorEmpresa.Empresa, ofertaPorEmpresa.Count);
            }
        }

        private void MostrarGraficoPorPuesto(object sender, EventArgs e)
        {
            // Agrupar las ofertas por puesto
            var ofertasPorPuesto = ofertas.GroupBy(o => o.JobName)
                                          .Where(g => g.Count() > 2)
                                          .Select(g => new { Puesto = g.Key, Count = g.Count() });

            // Limpiar el gráfico antes de agregar datos nuevos
            chart.Series.Clear();

            // Agregar una serie al gráfico
            var series = chart.Series.Add("Ofertas por Puesto");
            SeriesChartType tipoGrafico = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), cbStyle.SelectedItem.ToString());
            series.ChartType = SeriesChartType.Radar;

            // Agregar los puntos de datos al gráfico
            foreach (var ofertaPorPuesto in ofertasPorPuesto)
            {
                series.Points.AddXY(ofertaPorPuesto.Puesto, ofertaPorPuesto.Count);
            }
        }

        private void MostrarGraficoPorMes(object sender, EventArgs e)
        {
            // Agrupar las ofertas por mes
            var ofertasPorMes = ofertas.GroupBy(o => DateTime.Parse(o.Date).Month)
                                        .OrderBy(g => g.Key)
                                        .Select(g => new { Mes = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(g.Key), Count = g.Count() });

            // Limpiar el gráfico antes de agregar datos nuevos
            chart.Series.Clear();

            // Agregar una serie al gráfico
            var series = chart.Series.Add("Ofertas por Mes");
            SeriesChartType tipoGrafico = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), cbStyle.SelectedItem.ToString());
            series.ChartType = SeriesChartType.Column;

            // Agregar los puntos de datos al gráfico
            foreach (var ofertaPorMes in ofertasPorMes)
            {
                series.Points.AddXY(ofertaPorMes.Mes, ofertaPorMes.Count);
            }
        }

        private void cbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeriesChartType tipoGrafico = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), cbStyle.SelectedItem.ToString());
            foreach (var item in chart.Series)
            {
                item.ChartType = tipoGrafico;
            }
        }
    }
}
