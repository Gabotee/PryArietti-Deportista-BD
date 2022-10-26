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
    public partial class FrmPrincipal : Form
    {

        //Se crea la conexion de la base de datos
        public OleDbConnection ConexionBD;

        // q quiero traer desde la base de datos
        public OleDbCommand QueQuieroTraerDeLaBD;

        // lector de la base de datos
        public OleDbDataReader LectorBD;

        //variable de la ruta de la base de datos
        public string RutaBaseDeDatos = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "DEPORTE.accdb";

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                //Color Verde = Base de datos Conectada
                SsInicio.BackColor = Color.Green;
            }
            catch (Exception Indicador)
            {
                //Color Rojo = No se conecto a la base de datos
                SsInicio.BackColor = Color.Red;
            }
        }

        private void entrenadorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaEntrenador VentanaConsultaEntrenador = new FrmConsultaEntrenador();
            VentanaConsultaEntrenador.ShowDialog();
        }

        private void deportistaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaDeportista VentanaConsultaDeportista = new FrmConsultaDeportista();
            VentanaConsultaDeportista.ShowDialog();
        }

        private void entrenadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroEntrenador VentanaRegistroEntrenador = new FrmRegistroEntrenador();
            VentanaRegistroEntrenador.ShowDialog();
        }

        private void deportistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroDeportista VentanaRegistroDeportista = new FrmRegistroDeportista();
            VentanaRegistroDeportista.ShowDialog();
        }

        private void entrenadorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmModificarEntrenador VentanaModificarEntrenador = new FrmModificarEntrenador();
            VentanaModificarEntrenador.ShowDialog();
        }
    }
}
