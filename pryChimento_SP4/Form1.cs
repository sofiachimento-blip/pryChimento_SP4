using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Windows.Forms.DataVisualization.Charting;

namespace pryChimento_SP4
{
    public partial class frmPrincipal : Form
    {
        int progreso = 0;
        private object timerCarga;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboTipoGrafico.Items.Add("Gráfico de columna");
            cboTipoGrafico.Items.Add("Gráfico de línea");
            cboTipoGrafico.Items.Add("Gráfico de barra");
            cboTipoGrafico.Items.Add("Gráfico de puntos");
            cboTipoGrafico.SelectedIndex = 0; // valor por defecto
            ConexionaBD claseConexion = new ConexionaBD();
            claseConexion.ConectarBD(toolStripStatusLabelConex);
        }

        private void BtnCamion_Click(object sender, EventArgs e)
        {
            chartInfo.Series.Clear();
            ConexionaBD claseConexion = new ConexionaBD();
            claseConexion.CargarDatosChart(chartInfo);
        }

        private SeriesChartType ObtenerTipoGrafico()
        {
            switch (cboTipoGrafico.SelectedItem.ToString())
            {
                case "Gráfico de columna": return SeriesChartType.Column;
                case "Gráfico de línea": return SeriesChartType.Line;
                case "Gráfico de barra": return SeriesChartType.Bar;
                case "Gráfico de puntos": return SeriesChartType.Point;
                default: return SeriesChartType.Column;
            }
        }

        private void MostrarGrafico(string tituloSerie, string columnaY)
        {

            try
            {
                chartInfo.Series.Clear();
                chartInfo.Titles.Clear();
                chartInfo.ChartAreas[0].AxisX.Title = "Camión";
                chartInfo.ChartAreas[0].AxisY.Title = columnaY;

                
                string consulta = $"SELECT Camión, [{columnaY}] FROM TablaCamiones";
                DataTable dt = ConexionaBD.EjecutarConsulta(consulta);

               
                Series serie = new Series(tituloSerie);
                serie.ChartType = ObtenerTipoGrafico();
                serie.Color = Color.DodgerBlue;
                serie.IsValueShownAsLabel = true;

                
                foreach (DataRow fila in dt.Rows)
                {
                    serie.Points.AddXY(fila["Camión"].ToString(), Convert.ToDouble(fila[columnaY]));
                }

                
                chartInfo.Series.Add(serie);
                chartInfo.Titles.Add($"{tituloSerie}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar el gráfico: " + ex.Message);
            }
        }

        private async void btnCamion_Click(object sender, EventArgs e)
        {
            IniciarCarga();
            await GenerarGraficoConProgreso("Kilómetros por Camión", "Kilómetros");

        }

        private async Task btnGastosCamion_ClickAsync(object sender, EventArgs e)
        {
            IniciarCarga();
            await GenerarGraficoConProgreso("Total por Camión", "Total");
        }

        private async void btnGastosCamion_Click(object sender, EventArgs e)
        {


            IniciarCarga();
            await GenerarGraficoConProgreso("Total por Camión", "Total");

        }

        private async void btnKgCamion_Click(object sender, EventArgs e)
        {
            IniciarCarga();
            await GenerarGraficoConProgreso("Kilogramos por Camión", "Kilogramos");

        }

        private void btnGastosViaticos_Click(object sender, EventArgs e)
        {
            
            try
            {
                chartInfo.Series.Clear();
                chartInfo.Titles.Clear();

                chartInfo.ChartAreas[0].AxisY.Maximum = double.NaN;
                chartInfo.ChartAreas[0].RecalculateAxesScale();
                chartInfo.ChartAreas[0].AxisX.Title = "Camión";
                chartInfo.ChartAreas[0].AxisY.Title = "Total + Viáticos";

                
                string consulta = "SELECT [Camión], ([Total] + [Viáticos]) AS GastoTotal FROM TablaCamiones";

                DataTable dt = ConexionaBD.EjecutarConsulta(consulta);

                Series serie = new Series("Gastos y Viáticos por Camión");
                serie.ChartType = ObtenerTipoGrafico();
                serie.Color = Color.IndianRed;
                serie.IsValueShownAsLabel = true;

                foreach (DataRow fila in dt.Rows)
                {
                    serie.Points.AddXY(fila["Camión"].ToString(), Convert.ToDouble(fila["GastoTotal"]));
                }

                chartInfo.Series.Add(serie);
                chartInfo.Titles.Add("Gastos y Viáticos por Camión");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar el gráfico: " + ex.Message);
            }
        }

        private void IniciarCarga()
        {
            progreso = 0;
            progressBarCarga.Value = 0;
            progressBarCarga.Visible = true;
            timerCarga.Interval = 100; // velocidad del avance
            timerCarga.Start();
        }

        private void timerCarga_Tick(object sender, EventArgs e)
        {
            if (progreso < 100)
            {
                progreso += 10;
                progressBarCarga.Value = progreso;
            }
            else
            {
                timerCarga.Stop();
                progressBarCarga.Visible = false;
            }
        }

        private async Task GenerarGraficoConProgreso(string titulo, string columna)
        {
            // Inicializar barra
            progreso = 0;
            progressBarCarga.Value = 0;
            progressBarCarga.Visible = true;

            // Simular progreso visible
            for (int i = 0; i <= 100; i += 10)
            {
                progressBarCarga.Value = i;
                await Task.Delay(100); // avanza sin bloquear la interfaz
            }

            // Generar el gráfico
            MostrarGrafico(titulo, columna);

            // Terminar y ocultar la barra
            progressBarCarga.Value = 100;
            await Task.Delay(200);
            progressBarCarga.Visible = false;
        }


    }
}
