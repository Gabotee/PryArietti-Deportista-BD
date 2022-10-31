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
            ClaseCliente Deportista = new ClaseCliente();
            Deportista.Buscar(txtCodigo.Text);
            if (Deportista.CodigoDeportista != txtCodigo.Text)
            {
                MessageBox.Show("Codigo No encontrado");
            }
            else
            {
                txtNombre.Text = Deportista.Nombre;
                txtApellido.Text = Deportista.Apellido;
                txtDireccion.Text = Deportista.Direccion;
                lstDeporte.Text = Deportista.Deporte;
                txtProvincia.Text = Deportista.Provincia;
            }
            

        }

        private void FrmModificarEntrenador_Load(object sender, EventArgs e)
        {
            try
            {
                //Color Verde = Base de datos Conectada
                SsModificarEntrenador.BackColor = Color.Green;
            }
            catch (Exception Indicador)
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
            ClaseCliente Entrenador = new ClaseCliente();

            // le pasa la informacion escrita en los txt a la clase 
            Entrenador.Direccion = txtDireccion.Text;
            Entrenador.Provincia = txtProvincia.Text;
            Entrenador.Deporte = lstDeporte.Text;

            // Pasa el codigo que se debe modificar... 
            Entrenador.ModificarEntrenador(CodigoDeportista);

            MessageBox.Show("Datos Modificados");

        }
    }
}
