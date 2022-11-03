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

        //Contiene la tablas q voy a usar (Tambien se le puede poner el nombre de las tablas directamente)
        
        private string TablaDeportista = "DEPORTISTA";

        
        private string CodigoDep;
        private string Nom;
        private string Ape;
        private string Dir;
        private string Dep;
        private int tel;
        private int Ed;


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
        
        public Int32 Telefono
        {
            get { return tel;}
            set { tel = value; }
        }
        public Int32 Edad
        {
            get { return Ed; }
            set { Ed = value; }
        }
        public string Deporte
        {
            get { return Dep; }
            set { Dep = value; }
        }


        public void BuscarDeportista (string CodigoDeportista)
        {
            try
            {
                ConexionBD.ConnectionString = RutaBaseDeDatos;
                ConexionBD.Open();
                QueQuieroDeLaBase.Connection = ConexionBD;
                QueQuieroDeLaBase.CommandType = System.Data.CommandType.TableDirect;
                QueQuieroDeLaBase.CommandText = TablaDeportista;
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
                            tel = Leer.GetInt32(4);
                            Ed = Leer.GetInt32(5);
                            Dep = Leer.GetString(6);    
                        }
                    }
                }

                ConexionBD.Close();
            }
            catch (Exception)
            {
                
               // throw;
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
            catch (Exception )
            {
                
                //throw;
            }


        }


        public void ModificarDeportista (string CodigoDeportista)
        {
            try
            {
                // Poner comillas simples.. (Por eso no funcionaba)
                string ModificarDeportista = "UPDATE DEPORTISTA SET [DIRECCION] = '" + Direccion + "',[TELEFONO] ='" + Telefono + "',[EDAD] ='" + Edad + "',[DEPORTE] ='" + Deporte + "' WHERE [CODIGO DEPORTISTA] = '" + CodigoDeportista + "'";
                //Conectarse a la base de datos
                ConexionBD.ConnectionString = RutaBaseDeDatos;
                ConexionBD.Open();

                // toma la conexion
                QueQuieroDeLaBase.Connection = ConexionBD;

                // me trae la tabla del acces 
                QueQuieroDeLaBase.CommandType = System.Data.CommandType.Text;
                //Selecciona la tabla 
                QueQuieroDeLaBase.CommandText = ModificarDeportista;

                QueQuieroDeLaBase.ExecuteNonQuery();

                ConexionBD.Close();
            }
            catch (Exception)
            {

                //throw;
            }
        }
    }
}
