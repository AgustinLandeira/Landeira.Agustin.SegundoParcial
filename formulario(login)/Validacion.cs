using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulario_login_
{
    public delegate void Validar(string s);
    public class Validacion
    {
        private int edadIngresada;
        private int partidosJugados;
        private int goles_puntos_Vueltas;

        public event Validar validacion;

        public int Goles_Puntos_Vueltas
        {
            get { return goles_puntos_Vueltas; }
            set
            {
                this.goles_puntos_Vueltas = value;

                if(value < 0)
                {
                    this.validacion.Invoke($"los {this.goles_puntos_Vueltas} goles/vueltas/puntos del jugador son invalidos");
                }
            }
        }

        public int PartidosJugados
        {
            get { return partidosJugados; }
            set 
            { 
                this.partidosJugados = value;
                if( value < 0)
                {
                    this.validacion.Invoke($"los {this.partidosJugados} partidos  son invalidos");
                }
            
            }
        }

        public int EdadIngresada
        {
            get { return this.edadIngresada; }
            
            set     
            {
                this.edadIngresada = value;
                if(value <= 0)
                {
                    this.validacion.Invoke($"la edad {value} es invalida para el jugador");
                }
            }
        }
        public Validacion() 
        { 
            this.partidosJugados = 0;
            this.goles_puntos_Vueltas = 0;
            this.edadIngresada = 0;
            this.validacion += new Validar(FmrRegistro.EdadInvalida);
        
        }

    }
}
