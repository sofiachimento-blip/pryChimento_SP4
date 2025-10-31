using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryChimento_SP4
{
    internal class Conexion
    {
        public string mensaje = "";

        OleDbConnection connection;
        OleDbCommand command;

        public void ConexionDb (ToolStripLabel lblMensaje)
        {
            try
            {
                connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ..\\bin\\control_transporte.accdb");
                lblMensaje.Text = "Encontro la db";
                lblMensaje.BackColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "No encontro la base de datos";
                lblMensaje.BackColor = System.Drawing.Color.Red;
            }
        }

        public void Grafico (Chart chart)
        {
            Series serie = new Series("KM recorridos por camion");
            serie.ChartType = SeriesChartType.Column;

            try
            {
                connection.Open();
                string query = "Select camion, kilometros from transporte";
                command = new OleDbCommand(query, connection);
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string camion = reader["camion"].ToString();
                    decimal km = Convert.ToDecimal(reader["Kilometros"]);
                    serie.Points.AddXY(camion, km);
                }

                chart.Series.Add(serie);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
