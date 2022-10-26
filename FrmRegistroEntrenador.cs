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
    public partial class FrmRegistroEntrenador : Form
    {
        public FrmRegistroEntrenador()
        {
            InitializeComponent();
        }

        private void mrcEntrenador_Enter(object sender, EventArgs e)
        {

        }

        //Se crea la conexion de la base de datos
        public OleDbConnection ConexionBD;

        // q quiero traer desde la base de datos
        public OleDbCommand QueQuieroTraerDeLaBD;

        //variable de la ruta de la base de datos
        public string RutaBaseDeDatos = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "DEPORTE.accdb";

        private void FrmRegistroEntrenador_Load(object sender, EventArgs e)
        {
            try
            {
                //Con esto indico que la base de datos se conecto de manera exitosa
                SsRegistroEntrenador.BackColor = Color.Green;
            }
            catch (Exception Indicador)
            {
                //Con esto indico que no se pudo conectar con la base de datos
                SsRegistroEntrenador.BackColor = Color.Red;
            }

        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            string CodigoEntrenadores = txtCodigoEntrenador.Text;
            string Nombre = txtNombre.Text;
            string Apellido = txtApellido.Text;
            string Direccion = Convert.ToString(txtDireccion.Text);
            string Provincia = txtProvincia.Text;
            string Deporte = Convert.ToString(lstDeporte.SelectedItem);

            try
            {
                ConexionBD = new OleDbConnection(RutaBaseDeDatos);
                ConexionBD.Open();

                QueQuieroTraerDeLaBD = new OleDbCommand();

                QueQuieroTraerDeLaBD.Connection = ConexionBD;
                QueQuieroTraerDeLaBD.CommandType = CommandType.Text;

                QueQuieroTraerDeLaBD.CommandText = "INSERT INTO" + " ENTRENADORES ([CODIGO DEPORTISTA], [NOMBRE], [APELLIDO], [DIRECCION], [PROVINCIA], [DEPORTE])" +
                        " VALUES ('" + CodigoEntrenadores + "','" + Nombre + "','" + Apellido + "','" + Direccion + "','" + Provincia + "','" + Deporte + "')";

                QueQuieroTraerDeLaBD.ExecuteNonQuery();

                MessageBox.Show("Datos almacenados con exito");
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show("No se Puedo Registrar los datos" + Mensaje.Message);
                //throw;
            }

            Limpiar();

            ConexionBD.Close();


        }
        private void Limpiar()
        {
            //Limpia el todos los controladores
            txtCodigoEntrenador.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtProvincia.Text = "";
            lstDeporte.SelectedIndex = -1;
        }
    }
}
