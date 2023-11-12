using libreria_de_clases;
namespace principal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            if(accesoDatos.Conectado()) 
            {

                Console.WriteLine("se conecto");

            }
            else
            {
                Console.WriteLine(" no se conecto");
            }

            Console.ReadKey();
            /*JugadorDeFutbol j = new JugadorDeFutbol(32, "delantero", 21, "agustin", "landeira", 23, EDeporte.Futbol);

            Console.WriteLine(j.CalcularPromedio());
           //Console.WriteLine(((IJugador)j).CalcularPromedio());

            Console.WriteLine(j.Profesion());

            Console.WriteLine(((IJugador)j).Profesion());*/
        }
    }
}