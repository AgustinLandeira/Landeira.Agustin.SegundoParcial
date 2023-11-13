using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace libreria_de_clases
{
    public class Json<T> : IArchivos<T>
    {
        private List<T> listaUsuarios;
        
        public Json() 
        {
            List<T> listaUsuarios = new List<T>();

        }

       
        public List<T> Deserializar(string nombreArchivo)
        {
            try
            {
                using(StreamReader reader = new StreamReader(nombreArchivo))
                {
                    string json = reader.ReadToEnd();
                    this.listaUsuarios = JsonSerializer.Deserialize<List<T>>(json);
                    
                }
                

            }
            catch (JsonException jsonEx)
            {
                Console.WriteLine($"Error al deserializar el archivo JSON: {jsonEx.Message}");
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error al leer/deserializar el archivo JSON: {ex.Message}");


            }
            

            return this.listaUsuarios;

        }
    }
}
