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

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 1)
                {
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

        public void AgregarJugadorTabla(JugadorDeFutbol j)
        {
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandText = "INSERT INTO Tabla_Futbolista(Nombre,Apellido,Partidos_Jugados,Edad,Deporte,Posicion,Goles,Promedio)" +
                    "VALUES(@Nombre,@Apellido,@PartidosJugados,@Edad,@Deporte,@Posicion,@Goles,@Promedio) ";

                this.comando.Parameters.AddWithValue("@Nombre",((IJugador)j).Nombre);
                this.comando.Parameters.AddWithValue("@Apellido", ((IJugador)j).Apellido);
                this.comando.Parameters.AddWithValue("@PartidosJugados", j.PartidosJugados);
                this.comando.Parameters.AddWithValue("@Edad", (int)j.años);
                this.comando.Parameters.AddWithValue("@Deporte", j.Deporte.ToString());
                this.comando.Parameters.AddWithValue("@Posicion", j.posicion);
                this.comando.Parameters.AddWithValue("@Goles", j.Goles);
                this.comando.Parameters.AddWithValue("@Promedio",j.CalcularPromedio());

                this.comando.Connection = this.conexion;
                this.conexion.Open();
                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 1)
                {
                }
                
            }
            catch(SqlException ex)
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

        public void AgregarJugadorTabla(JugadorDeBeisbol j)
        {
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandText = "INSERT INTO Tabla_Beisbolistas(Nombre,Apellido,Partidos_Jugados,Edad,Deporte,Accesorio,Cantidad_Vueltas,Promedio)" +
                    "VALUES(@Nombre,@Apellido,@PartidosJugados,@Edad,@Deporte,@Accesorio,@Vueltas,@Promedio)";

                this.comando.Parameters.AddWithValue("@Nombre", ((IJugador)j).Nombre);
                this.comando.Parameters.AddWithValue("@Apellido", ((IJugador)j).Apellido);
                this.comando.Parameters.AddWithValue("@PartidosJugados", j.PartidosJugados);
                this.comando.Parameters.AddWithValue("@Edad", (int)j.años);
                this.comando.Parameters.AddWithValue("@Deporte", j.Deporte.ToString());
                this.comando.Parameters.AddWithValue("@Accesorio", j.Accesorio);
                this.comando.Parameters.AddWithValue("@Vueltas", j.VueltasMaximas);
                this.comando.Parameters.AddWithValue("@Promedio", j.CalcularPromedio());

                this.comando.Connection = this.conexion;
                this.conexion.Open();
                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 1)
                {
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

        public void ModificarFila(Jugadores j,string nombreOriginal,string apellidoOriginal)
        {
            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@nombreOriginal", nombreOriginal);
                this.comando.Parameters.AddWithValue("@apellidoOriginal", apellidoOriginal);
                this.comando.Parameters.AddWithValue("@Nombre", ((IJugador)j).Nombre);
                this.comando.Parameters.AddWithValue("@Apellido", ((IJugador)j).Apellido);
                this.comando.Parameters.AddWithValue("@PartidosJugados", j.partidosJugados);
                this.comando.Parameters.AddWithValue("@Edad", (int)j.años);
                this.comando.Parameters.AddWithValue("@Deporte", j.Deporte.ToString());
                
                if (j is JugadorDeFutbol)
                {
                    this.comando.Parameters.AddWithValue("@Posicion", ((JugadorDeFutbol)j).Posicion);
                    this.comando.Parameters.AddWithValue("@Goles", ((JugadorDeFutbol)j).Goles);
                    this.comando.Parameters.AddWithValue("@Promedio", ((JugadorDeFutbol)j).CalcularPromedio());

                    this.comando.CommandType = System.Data.CommandType.Text;
                    this.comando.CommandText = "update Tabla_Futbolista set Nombre=@Nombre,Apellido =@Apellido,Partidos_Jugados = @PartidosJugados," +
                        "Edad=@Edad,Deporte=@Deporte,Posicion=@Posicion,Goles=@Goles,Promedio=@Promedio where Nombre = @nombreOriginal and Apellido =  @apellidoOriginal";
                    
                }else if(j is JugadorDeBasket)
                {
                    this.comando.Parameters.AddWithValue("@Puntos",((JugadorDeBasket)j).Puntos);
                    this.comando.Parameters.AddWithValue("@Objetivo", ((JugadorDeBasket)j).Objetivo);
                    this.comando.Parameters.AddWithValue("@Promedio", ((JugadorDeBasket)j).CalcularPromedio());

                    this.comando.CommandType = System.Data.CommandType.Text;
                    this.comando.CommandText = "update Tabla_Basketbolistas set Nombre=@Nombre,Apellido =@Apellido,Partidos_Jugados = @PartidosJugados," +
                        "Edad=@Edad,Deporte=@Deporte,Objetivo=@Objetivo,Puntos=@Puntos,Promedio=@Promedio where Nombre = @nombreOriginal and Apellido =  @apellidoOriginal";
                }

                this.comando.Connection = this.conexion;
                this.conexion.Open();
                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 1)
                {

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
