using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace libreria_de_clases
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private static string cadena_conexion;

        static AccesoDatos()
        {
            AccesoDatos.cadena_conexion = Properties.Resources.miConexion;
        }

        public AccesoDatos()
        {
            this.conexion = new SqlConnection(AccesoDatos.cadena_conexion);
        }

        public bool Conectado()
        {
            bool booleano = false;

            try
            {
                this.conexion.Open();
                booleano =  true;
            }catch (Exception)
            {

            }finally 
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }    
            }

            return booleano;
        }
    }
}
