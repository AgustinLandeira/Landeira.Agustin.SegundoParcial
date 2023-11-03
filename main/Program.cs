using libreria_de_clases;
using System.Runtime.CompilerServices;
using System.Text.Json;



namespace main
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Usuario> usuarios = new List<Usuario>(); 

            JugadorDeFutbol jugadorFutbol = new JugadorDeFutbol(30, "mediocampista", 2, "mauro", "hry", 19, EDeporte.Futbol);
            JugadorDeFutbol jugadores = new JugadorDeFutbol(15,"delantero",2,"agustin","landeira",19,EDeporte.Futbol);
            JugadorDeBasket jugadorBasquet = new JugadorDeBasket(500, "aro",12, "fede", "sanabria",10, EDeporte.Basquet);
            JugadorDeBeisbol jugadorDeBeisbol = new JugadorDeBeisbol("casco",12,11,"barry","allen",15,EDeporte.Beisbol);
            Registro miRegistro = new Registro();

            JugadorDeBeisbol beisbolista = 300;

            /*Console.WriteLine(jugadores.CalcularPromedio());
            Console.WriteLine(jugadorBasquet.CalcularPromedio());
            Console.WriteLine(jugadorDeBeisbol.CalcularPromedio());*/

            List<Jugadores> lista = new List<Jugadores>();

            lista.Add(jugadorBasquet);
            lista.Add(jugadorDeBeisbol);
            lista.Add(jugadores);

            /*foreach(Jugadores jugador in lista)
            {
                Console.WriteLine("----------------------------------------");

                Console.WriteLine(jugador);

                Console.WriteLine("----------------------------------------");
            }*/

            if (jugadores.Equals(jugadorBasquet))
            {
                Console.WriteLine("repetido");
            }

            miRegistro += jugadorBasquet;
            miRegistro += jugadorBasquet;

            miRegistro -= jugadorBasquet;

            lista.Sort(Registro.OrdenarPorPartidosJugadosAsc);

            foreach (Jugadores jugador in lista)
            {
                Console.WriteLine("----------------------------------------");

                Console.WriteLine(jugador);

                Console.WriteLine("----------------------------------------");
            }
            Console.WriteLine("ahora de forma descendete\n");
            lista.Sort(Registro.OrdenarPorAñosDesc);

            /*foreach (Jugadores jugador in miRegistro.ListaJugadores)
            {
                Console.WriteLine("----------------------------------------");

                Console.WriteLine(jugador);

                Console.WriteLine("----------------------------------------");
            }*/

            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string nombreArchivo = "Parcial.json"; 
            string rutaCompleta = Path.Combine(escritorio, nombreArchivo);
           /* if (File.Exists(rutaCompleta))
            {
                try
                {
                    using (StreamReader lectroJson = new StreamReader(rutaCompleta))
                    {
                        string jsonString = lectroJson.ReadToEnd();
                        //usuarios = (List<MiClase>)JsonSerializer.Deserialize(jsonString, typeof(List<MiClase>));
                        List<Usuario> usuarios = JsonSerializer.Deserialize<List<Usuario>>(jsonString);
                    }

                    for (int i = 0; i < usuarios.Count; i++)
                    {
                        Console.WriteLine($"Apellido {i}: {usuarios[i].apellido}");
                    }
                   
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al leer/deserializar el archivo JSON: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("no se encontro");
            }*/
        }
    }
}