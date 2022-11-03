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
            catch (Exception Indicador)
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
            Registro.Edad = Convert.ToInt32(txtEdad.Text);
            Registro.Telefono = Convert.ToInt32(txtTelefono.Text);
            Registro.Deporte =  Convert.ToString(lstDeporte.SelectedItem);
            Registro.Agregar();
            MessageBox.Show("Los Datos se cargaron correctamente");
            Limpiar();



            //string CodigoDeportista = txtCodigoDeportista.Text;
            //string Nombre = txtNombre.Text;
            //string Apellido = txtApellido.Text;
            //string Direccion = Convert.ToString(txtDireccion.Text);
            //string Edad = Convert.ToString(txtEdad.Text);
            //string Telefono = Convert.ToString(txtTelefono);
            //string Deporte = Convert.ToString(lstDeporte.SelectedItem);

            //try
            //{
            //    ConexionBD = new OleDbConnection(RutaBaseDeDatos);
            //    ConexionBD.Open();

            //    QueQuieroTraerDeLaBD = new OleDbCommand();

            //    QueQuieroTraerDeLaBD.Connection = ConexionBD;
            //    QueQuieroTraerDeLaBD.CommandType = CommandType.Text;

            //    QueQuieroTraerDeLaBD.CommandText = "INSERT INTO" + " DEPORTISTA ([CODIGO DEPORTISTA], [NOMBRE], [APELLIDO], [DIRECCION],[TELEFONO],[EDAD], [DEPORTE])" +
            //            " VALUES ('" + CodigoDeportista + "','" + Nombre + "','" + Apellido + "','" + Direccion + "','" + Telefono + "','" + Edad + "','" + Deporte + "')";

            //    QueQuieroTraerDeLaBD.ExecuteNonQuery();

            //    MessageBox.Show("Datos almacenados con exito");
            //}
            //catch (Exception Mensaje)
            //{
            //    MessageBox.Show("No Se pudo Registrar los datos" + Mensaje.Message);
            //    //throw;
            //}

            //Limpiar();

            //ConexionBD.Close();

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
