using formulario_login_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria_de_clases
{
    public delegate void  Notificacion(string s);
    public delegate void Jugador(string s);
    public class Notificaciones
    {
        private string profesion;
        private string nombreJugador;

        public string NombreJugador
        {
            set
            {
                this.nombreJugador = value;
                this.MostrarJugador.Invoke($"el jugador llamado {this.nombreJugador} ya esta en la lista");
            }
        }

        public string Profesion
        {
            get
            {
                
                return this.profesion;
            }
            set
            {
                this.profesion = value;
                this.ValidacionPerfiles.Invoke($"no podes entrar porque sos {this.profesion}");
            }
        }
        public Notificaciones() 
        {
            this.nombreJugador = "";
            this.profesion = "indefinido";
            this.ValidacionPerfiles += new Notificacion(FmrRegistro.Notificar);
            this.MostrarJugador += new Jugador(FmrRegistro.MostrarJugadorRepetido);
        
        }

        public event Notificacion ValidacionPerfiles;
        public event Jugador MostrarJugador;
    }
}
