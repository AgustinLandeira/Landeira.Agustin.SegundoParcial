﻿using System;
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
        private SqlCommand comando;

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

        public void AgregarJugadorTabla(JugadorDeBasket j)
        {
            try
            {
                if(j is JugadorDeBasket)
                {
                    this.comando = new SqlCommand();
                    this.comando.CommandText = "INSERT INTO Tabla_Basketbolistas (Nombre, Apellido, Partidos_Jugados, Edad, Deporte, Objetivo, Puntos, Promedio)" +
                    "VALUES (@Nombre, @Apellido, @PartidosJugados, @Edad, @Deporte, @Objetivo, @Puntos, @Promedio)";

                    this.comando.Parameters.AddWithValue("@Nombre", ((IJugador)j).Nombre);
                    this.comando.Parameters.AddWithValue("@Apellido", ((IJugador)j).Apellido);
                    this.comando.Parameters.AddWithValue("@PartidosJugados", j.PartidosJugados);
                    this.comando.Parameters.AddWithValue("@Edad", (int)j.años);
                    this.comando.Parameters.AddWithValue("@Deporte", j.Deporte.ToString());
                    this.comando.Parameters.AddWithValue("@Objetivo", j.objetivo);
                    this.comando.Parameters.AddWithValue("@Puntos", j.Puntos);
                    this.comando.Parameters.AddWithValue("@Promedio", j.CalcularPromedio());
                    this.comando.Connection = this.conexion;
                    this.conexion.Open();
                    int filasAfectadas = this.comando.ExecuteNonQuery(); // devuelve las filas afectadas

                    if (filasAfectadas == 1)
                    {
                        
                    }

                }
               

            }
            catch (SqlException ex)
            {
               
                Console.WriteLine("Error de SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

        }


    }
}
