using formulario_login_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria_de_clases
{
    public delegate void  Notificacion(string s);
    public delegate void Profesion(string s);
    public class Validaciones
    {
        private string profesion;

        public string Profesion
        {
            get
            {
                //this.MostrarPerfil.Invoke($"Perfil: {this.profesion}");
                return this.profesion;
            }
            set
            {
                this.profesion = value;
                this.ValidacionPerfiles.Invoke($"no podes entrar porque sos {this.profesion}");
            }
        }
        public Validaciones() 
        {
            this.profesion = "indefinido";
            this.ValidacionPerfiles += new Notificacion(FmrRegistro.Notificar);
            //this.MostrarPerfil += new Profesion(FmrRegistro.MostrarPerfil);
        
        }

        public event Notificacion ValidacionPerfiles;
       // public event Profesion MostrarPerfil;
    }
}
