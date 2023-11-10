using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace libreria_de_clases
{
    public class Xml:IArchivos<Jugadores>
    {
        private List<Jugadores> jugadores;
        public Xml()
        {
            this.jugadores = new List<Jugadores>(); 
        }

        public List<Jugadores> Deserializar(string nombreArchivo)
        {
            try
            {
                using (XmlTextReader lectorxml = new XmlTextReader(nombreArchivo))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(List<Jugadores>));
                    this.jugadores = (List<Jugadores>)serializador.Deserialize(lectorxml);

                   
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return this.jugadores;
        }
    }
    
}
