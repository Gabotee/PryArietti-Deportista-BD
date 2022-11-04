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
    public partial class FrmEliminarEntrenador : Form
    {
        //Conexion Base de datos
        OleDbConnection ConexionBD = new OleDbConnection();
        //Me trae lo que quiero de la base de datos 
        OleDbCommand QueQuieroDeLaBase = new OleDbCommand();

        OleDbDataAdapter Adaptador = new OleDbDataAdapter();

        //Variable q almacena el proveedor + la ruta de la base de datos
        public string RutaBaseDeDatos = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "DEPORTE.accdb";
        public FrmEliminarEntrenador()
        {
            InitializeComponent();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            //Llamo a la clase y al procedimiento ELIMINAR
            //y este eliminara toda la fila seleccionada
            //por el CodigoDeportista
            string CodigoDeportista = txtCodigo.Text;
            ClaseEntrenador Eliminar = new ClaseEntrenador();
            Eliminar.EliminarEntrenador(CodigoDeportista);

            MessageBox.Show("Entranador Eliminado Correctamente");

            Limpiar();

           
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

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
           
            
        }

        private void FrmEliminarEntrenador_Load(object sender, EventArgs e)
        {
            try
            {
                //Color Verde = Base de datos Conectada
                SsElimarEntrenador.BackColor = Color.Green;
            }
            catch (Exception)
            {
                //Color Rojo = No se conecto a la base de datos
                SsElimarEntrenador.BackColor = Color.Red;
            }
        }

        private void cmdBuscar_Click_1(object sender, EventArgs e)
        {
            ClaseEntrenador Buscar = new ClaseEntrenador();
            Buscar.BuscarEntrenador(txtCodigo.Text);

            if (Buscar.CodigoDeportista != txtCodigo.Text)
            {
                MessageBox.Show("Codigo No encontrado");
            }
            else
            {
                txtNombre.Text = Buscar.Nombre;
                txtApellido.Text = Buscar.Apellido;
                txtDireccion.Text = Buscar.Direccion;
                lstDeporte.Text = Buscar.Deporte;
                txtProvincia.Text = Buscar.Provincia;
            }
        }
    }


}
