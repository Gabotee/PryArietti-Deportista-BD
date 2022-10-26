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

namespace PryArietti_Deportista_BD
{
    public partial class FrmConsultaEntrenador : Form
    {

        OleDbConnection conexionBase;
        OleDbCommand queQuieroDeLaBase;
        OleDbDataReader lectorDeConsultas;
        string varRutaDeBaseDeDatos = "DEPORTE.accdb";

        public FrmConsultaEntrenador()
        {
            InitializeComponent();
        }

        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            dgvMostrarEntrenador.Rows.Clear();

            try
            {
                conexionBase = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                   varRutaDeBaseDeDatos);

                conexionBase.Open();

                queQuieroDeLaBase = new OleDbCommand();
                queQuieroDeLaBase.Connection = conexionBase;
                queQuieroDeLaBase.CommandType = CommandType.TableDirect;
                queQuieroDeLaBase.CommandText = "ENTRENADORES";

                lectorDeConsultas = queQuieroDeLaBase.ExecuteReader();

                while (lectorDeConsultas.Read())
                {

                    dgvMostrarEntrenador.Rows.Add(lectorDeConsultas["Codigo Deportista"], lectorDeConsultas["Nombre"], lectorDeConsultas["Apellido"], lectorDeConsultas["Direccion"], lectorDeConsultas["Provincia"], lectorDeConsultas["Deporte"]);

                }

                lectorDeConsultas.Close();
                conexionBase.Close();

            }
            catch (Exception Mensajito)
            {
                MessageBox.Show(Mensajito.Message);
                //throw;
            }
        }
    }
}
