using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace pryChimento_SP4
{
    internal class ConexionaBD
    {
       private static string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\Base de Datos\\ControlCamiones.accdb;";

        OleDbConnection conexionBd;

        OleDbCommand comandoBd;
        OleDbDataReader lectorDataReader;
        public string nombreBaseDeDatos;

        public string mensaje = "";

        public void ConectarBD(ToolStripStatusLabel label)
        {
            try
            {
                conexionBd = new OleDbConnection(cadenaConexion);

                nombreBaseDeDatos = conexionBd.Database;

                conexionBd.Open();

                label.Text = "Conectado a base de datos";
                label.BackColor = System.Drawing.Color.LightGreen;
            }
            catch (Exception error)
            {
                label.Text = "Error al conectar: " + error.Message;
                label.BackColor = System.Drawing.Color.LightCyan;
            }
        }

        public void CargarDatosChart(Chart chartInfo)
        {
            try
            {
                chartInfo.Series.Add("Camiones");
                chartInfo.ChartAreas[0].AxisX.Title = "Camiones";
                chartInfo.ChartAreas[0].AxisY.Title = "Kilometros";
                conexionBd = new OleDbConnection(cadenaConexion);
                conexionBd.Open();
                comandoBd = new OleDbCommand();
                comandoBd.Connection = conexionBd;
                comandoBd.CommandText = "SELECT Camión, Kilómetros FROM TablaCamiones";
                lectorDataReader = comandoBd.ExecuteReader();

                while (lectorDataReader.Read())
                {
                    string camion = lectorDataReader[0].ToString();
                    Int32 kilometros = Convert.ToInt32(lectorDataReader[1]);
                    int index = chartInfo.Series[0].Points.AddY(kilometros);
                    chartInfo.Series[0].Points[index].AxisLabel = camion;
                }


            }
            catch
            {
                MessageBox.Show("No se pudieron obtener los datos solicitados.");
            }





        }
        public static DataTable EjecutarConsulta(string consulta)
        {
            DataTable dt = new DataTable();

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open();
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion);
                    adaptador.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
            }

            return dt;
        }

    }
}
