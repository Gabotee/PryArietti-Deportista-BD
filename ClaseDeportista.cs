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
        OleDbConnection ConexionBD = new OleDbConnection();
        OleDbCommand QueQuieroDeLaBase = new OleDbCommand();
        OleDbDataAdapter Adaptador = new OleDbDataAdapter();

        public string RutaBaseDeDatos = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "DEPORTE.accdb";
        private string TablaEntrenador = "Entrenadores";

        private string  CodigoDep;
        private string Nom;
        private string Ape;
        private string Dir;
        private string Dep;
        private string Prov; 

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

        public void Buscar(string CodigoDeportista)
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
    }
}
