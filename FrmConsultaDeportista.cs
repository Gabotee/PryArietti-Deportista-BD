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
    public partial class FrmConsultaDeportista : Form
    {

        OleDbConnection conexionBase;
        OleDbCommand queQuieroDeLaBase;
        OleDbDataReader lectorDeConsultas;
        string varRutaDeBaseDeDatos = "DEPORTE.accdb";

        public FrmConsultaDeportista()
        {
            InitializeComponent();
        }

        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            dgvMostrarDeportistas.Rows.Clear();
            try
            {
                conexionBase = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                   varRutaDeBaseDeDatos);

                conexionBase.Open();

                queQuieroDeLaBase = new OleDbCommand();
                queQuieroDeLaBase.Connection = conexionBase;
                queQuieroDeLaBase.CommandType = CommandType.TableDirect;
                queQuieroDeLaBase.CommandText = "DEPORTISTA";

                lectorDeConsultas = queQuieroDeLaBase.ExecuteReader();

                

                while (lectorDeConsultas.Read())
                {

                    dgvMostrarDeportistas.Rows.Add(lectorDeConsultas["Codigo Deportista"], lectorDeConsultas["Nombre"], lectorDeConsultas["Apellido"], lectorDeConsultas["Direccion"], lectorDeConsultas["Telefono"], lectorDeConsultas["Edad"], lectorDeConsultas["Deporte"]);

                }

                lectorDeConsultas.Close();
                conexionBase.Close();
            }
            catch (Exception mensajito)
            {
                MessageBox.Show(mensajito.Message);
                //throw;
            }
        }
    }
}
