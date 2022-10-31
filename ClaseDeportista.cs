using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace PryArietti_Deportista_BD
{
    internal class ClaseCliente
    {
        //Conexion Base de datos
        OleDbConnection ConexionBD = new OleDbConnection();
        //Me trae lo que quiero de la base de datos 
        OleDbCommand QueQuieroDeLaBase = new OleDbCommand();

        OleDbDataAdapter Adaptador = new OleDbDataAdapter();

        //Variable q almacena el proveedor + la ruta de la base de datos
        public string RutaBaseDeDatos = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "DEPORTE.accdb";

        //Almacenan las tablas q voy a usar (Tambien se le puede poner el nombre de las tablas directamente)
        private string TablaEntrenador = "Entrenadores";
        private string TablaDeportista = "Deportista";

        
        private string CodigoDep;
        private string Nom;
        private string Ape;
        private string Dir;
        private string Dep;
        private string Prov;
        private string tel;
        private string Ed;


        //Get: Retorna lo de las variables
        //Set: Toma el valor y lo almacena

        public string CodigoDeportista
        {
            get { return CodigoDep; }
            set { CodigoDep = value; }
        }
        public string Nombre
        {
            get { return Nom; }
            set { Nom = value; }
        }
        public string Apellido
        {
            get { return Ape; } 
            set { Ape = value; }
        }
        public string Direccion
        {
            get { return Dir; }
            set { Dir = value; }
        }
        public string Deporte
        {
            get { return Dep; }
            set { Dep = value; }
        }
        public string Provincia
        {
            get { return Prov; }
            set { Prov = value; }
        }

        public string Telefono
        {
            get { return tel;}
            set { tel = value; }
        }
        public string Edad
        {
            get { return Ed; }
            set { Ed = value; }
        }

        public void Buscar (string CodigoDeportista)
        {
            try
            {
                ConexionBD.ConnectionString = RutaBaseDeDatos;
                ConexionBD.Open();
                QueQuieroDeLaBase.Connection = ConexionBD;
                QueQuieroDeLaBase.CommandType = System.Data.CommandType.TableDirect;
                QueQuieroDeLaBase.CommandText = TablaEntrenador;
                OleDbDataReader Leer = QueQuieroDeLaBase.ExecuteReader();

                if (Leer.HasRows)
                {
                    while (Leer.Read())
                    {
                        if (Leer.GetString(0) == CodigoDeportista)
                        {
                            CodigoDep = Leer.GetString(0);
                            Nom = Leer.GetString(1);
                            Ape = Leer.GetString(2);
                            Dir = Leer.GetString(3);
                            Dep = Leer.GetString(5);
                            Prov = Leer.GetString(4);
                        }
                    }
                }
                ConexionBD.Close();
            }
            catch (Exception)
            {

                throw;
            }


            
        }

        public void Agregar()
        {
            try
            {
                String AgregarDeportista = "INSERT INTO" + " DEPORTISTA ([CODIGO DEPORTISTA], [NOMBRE], [APELLIDO], [DIRECCION],[TELEFONO],[EDAD], [DEPORTE])" +
                        " VALUES ('" + CodigoDeportista + "','" + Nombre + "','" + Apellido + "','" + Direccion + "','" + Telefono + "','" + Edad + "','" + Deporte + "')";

                //Conectarse a la base de datos
                ConexionBD.ConnectionString = RutaBaseDeDatos;
                ConexionBD.Open();

                // toma la conexion
                QueQuieroDeLaBase.Connection = ConexionBD;

                // me trae la tabla del acces 
                QueQuieroDeLaBase.CommandType = System.Data.CommandType.Text;
                //Selecciona la tabla 
                QueQuieroDeLaBase.CommandText = AgregarDeportista;
                QueQuieroDeLaBase.ExecuteNonQuery();

                ConexionBD.Close();
            }
            catch (Exception mensaje)
            {
                
                //throw;
            }


        }

        public void Modificar (string CodigoDeportista)
        {
            try
            {
                string ModificarEntrenador = "UPDATE ENTRENADORES SET ([DIRECCION],[PROVINCIA],[DEPORTE] WHERE [CODIGO DEPORTISTA] = " + CodigoDeportista;
                //Conectarse a la base de datos
                ConexionBD.ConnectionString = RutaBaseDeDatos;
                ConexionBD.Open();

                // toma la conexion
                QueQuieroDeLaBase.Connection = ConexionBD;

                // me trae la tabla del acces 
                QueQuieroDeLaBase.CommandType = System.Data.CommandType.Text;
                //Selecciona la tabla 
                QueQuieroDeLaBase.CommandText = ModificarEntrenador;

                QueQuieroDeLaBase.ExecuteNonQuery();

                ConexionBD.Close();
            }
            catch (Exception mensaje)
            {

                //throw;
            }


        }
    }
}
