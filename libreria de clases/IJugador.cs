using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria_de_clases
{
    public interface IJugador
    {
        string Profesion();
        
        string Nombre { get; set; }
        string Apellido { get; set; }

        int Años { get; set; }
    }
}
