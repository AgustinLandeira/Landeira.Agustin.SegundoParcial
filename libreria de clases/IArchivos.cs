using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria_de_clases
{
    public interface IArchivos<T>
    {
        List<T> Deserializar(string nombreArchivo);
    }
}
