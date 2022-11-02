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
    public partial class FrmModificarDeportista : Form
    {
        public FrmModificarDeportista()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string CodigoDeportista = txtCodigo.Text;

            ClaseCliente Deportista = new ClaseCliente();

            Deportista.BuscarDeportista(CodigoDeportista);

            if (Deportista.CodigoDeportista != txtCodigo.Text)
            {
                MessageBox.Show("Deportista no encontrado");
            }
            else
            {
                txtNombre.Text = Deportista.Nombre;
                txtApellido.Text = Deportista.Apellido;
                txtDireccion.Text = Deportista.Direccion;
                txtTelefono.Text = Deportista.Telefono;
                txtEdad.Text = Deportista.Edad;
                lstDeporte.Text = Deportista.Deporte;
            }

            
        }

        private void FrmModificarDeportista_Load(object sender, EventArgs e)
        {
            try
            {
                //Color Verde = Base de datos Conectada
                SsDeportista.BackColor = Color.Green;
            }
            catch (Exception)
            {

                //Color Rojo = No se conecto a la base de datos
                SsDeportista.BackColor = Color.Red;
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            string CodigoDeportista = txtCodigo.Text;

            //crear Objeto de la clase Deportista 
            ClaseCliente Deportista = new ClaseCliente();

            // le pasa la informacion escrita en los txt a la clase 
            Deportista.Nombre = txtNombre.Text;
            Deportista.Apellido = txtApellido.Text;
            Deportista.Direccion = txtDireccion.Text;
            Deportista.Telefono = txtTelefono.Text;
            Deportista.Edad = txtEdad.Text;
            Deportista.Deporte = lstDeporte.Text;

            // Pasa el codigo que se debe modificar... 
            Deportista.ModificarDeportista(CodigoDeportista);

            MessageBox.Show("Datos Modificados");

           
        }

        private void Limpiar()
        {
            //Limpia el todos los controladores
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEdad.Text = "";
            lstDeporte.SelectedIndex = -1;
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
