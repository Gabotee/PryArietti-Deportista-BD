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
    public partial class FrmRegistroDeportista : Form
    {
        public FrmRegistroDeportista()
        {
            InitializeComponent();
        }

        //Se crea la conexion de la base de datos
        public OleDbConnection ConexionBD;

        // q quiero traer desde la base de datos
        public OleDbCommand QueQuieroTraerDeLaBD;

        //variable de la ruta de la base de datos
        public string RutaBaseDeDatos = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "DEPORTE.accdb";

        private void FrmRegistroDeportista_Load(object sender, EventArgs e)
        {
            try
            {
                //Con esto indico que la base de datos se conecto de manera exitosa
                SsRegistroDeportista.BackColor = Color.Green;
            }
            catch (Exception )
            {
                //Con esto indico que no se pudo conectar con la base de datos
                SsRegistroDeportista.BackColor = Color.Red;
            }

        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {

            ClaseCliente Registro = new ClaseCliente();
            Registro.CodigoDeportista = txtCodigoDeportista.Text;
            Registro.Nombre = txtNombre.Text;
            Registro.Apellido = txtApellido.Text;
            Registro.Direccion = txtDireccion.Text;
            Registro.Edad = txtEdad.Text;
            Registro.Telefono = txtTelefono.Text;
            Registro.Deporte = Convert.ToString(lstDeporte.SelectedItem);
            Registro.Agregar();
            MessageBox.Show("Los Datos se cargaron correctamente");
            Limpiar();




        }
        private void Limpiar()
        {
            //Limpia el todos los controladores
            txtCodigoDeportista.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtEdad.Text = "";
            txtTelefono.Text = "";
            lstDeporte.SelectedIndex = -1;
        }
    }
}
