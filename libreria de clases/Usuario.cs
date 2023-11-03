using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria_de_clases
{
    public class Usuario
    {
        public Usuario() 
        {
            this.apellido = "indefinido";
            this.nombre = "indefinido";
            this.legajo = 0;
            this.correo = "indefinido";
            this.clave = "indefinido";
            this.perfil = "indefinido";

        }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public int legajo { get; set; }
        public string correo { get; set; }
        public string clave { get; set; }
        public string perfil { get; set; }

        public DateTime Fecha { get; set; }
    }
}
