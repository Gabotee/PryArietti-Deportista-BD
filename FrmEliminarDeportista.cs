using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryArietti_Deportista_BD
{
    public partial class FrmEliminarDeportista : Form
    {
        public FrmEliminarDeportista()
        {
            InitializeComponent();
        }

        private void FrmEliminarDeportista_Load(object sender, EventArgs e)
        {
            try
            {
                //Color Verde = Base de datos Conectada
                SsEliminarDeportista.BackColor = Color.Green;
            }
            catch (Exception)
            {
                //Color Rojo = No se conecto a la base de datos
                SsEliminarDeportista.BackColor = Color.Red;
            }
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            ClaseCliente Deportista = new ClaseCliente();
            Deportista.BuscarDeportista(txtCodigo.Text);
            if (Deportista.CodigoDeportista != txtCodigo.Text)
            {
                MessageBox.Show("Codigo No Encontrado");
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

        private void mrcDatos_Enter(object sender, EventArgs e)
        {

        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            ClaseCliente deportista = new ClaseCliente();
            deportista.EliminarDeportista(txtCodigo.Text);
            MessageBox.Show("Datos Eliminados");

            Limpiar();

        }

        private void Limpiar()
        {
            //Limpia el todos los controladores
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtEdad.Text = "";
            txtTelefono.Text = "";
            lstDeporte.SelectedIndex = -1;

        }
    }
}
