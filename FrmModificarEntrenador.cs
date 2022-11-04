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
    public partial class FrmModificarEntrenador : Form
    {
        public FrmModificarEntrenador()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            ClaseEntrenador Entrenador = new ClaseEntrenador();

            Entrenador.BuscarEntrenador(txtCodigo.Text);
            if (Entrenador.CodigoDeportista != txtCodigo.Text)
            {
                MessageBox.Show("Codigo No encontrado");
            }
            else
            {
                txtNombre.Text = Entrenador.Nombre;
                txtApellido.Text = Entrenador.Apellido;
                txtDireccion.Text = Entrenador.Direccion;
                lstDeporte.Text = Entrenador.Deporte;
                txtProvincia.Text = Entrenador.Provincia;
            }
            

        }

        private void FrmModificarEntrenador_Load(object sender, EventArgs e)
        {
            try
            {
                //Color Verde = Base de datos Conectada
                SsModificarEntrenador.BackColor = Color.Green;
            }
            catch (Exception )
            {
                //Color Rojo = No se conecto a la base de datos
                SsModificarEntrenador.BackColor = Color.Red;
            }
        }


        private void Limpiar()
        {
            //Limpia el todos los controladores
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtProvincia.Text = "";
            lstDeporte.SelectedIndex = -1;
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            string CodigoDeportista = txtCodigo.Text;

            //crear Objeto de la clase Deportista 
            ClaseEntrenador Entrenador = new ClaseEntrenador();

            // le pasa la informacion escrita en los txt a la clase 
            Entrenador.Nombre = txtNombre.Text;
            Entrenador.Apellido = txtApellido.Text;
            Entrenador.Direccion = txtDireccion.Text;
            Entrenador.Provincia = txtProvincia.Text;
            Entrenador.Deporte = lstDeporte.Text;

            // Pasa el codigo que se debe modificar... 
            Entrenador.ModificarEntrenador(CodigoDeportista);

            MessageBox.Show("Datos Modificados");

            Limpiar();

        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtDireccion.Enabled = true;
            lstDeporte.Enabled = true;
            txtProvincia.Enabled = true;

            txtNombre.Focus();
        }
    }
}
