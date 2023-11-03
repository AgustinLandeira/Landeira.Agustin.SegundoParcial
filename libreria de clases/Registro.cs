using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace libreria_de_clases
{
    public class Registro
    {
        private List<Jugadores> listaJugadores;

        public List<Jugadores> ListaJugadores
        {
            get { return this.listaJugadores; }
            set { this.listaJugadores = value; }
        }


        public Registro() 
        {
            listaJugadores = new List<Jugadores>();
        
        }

        
        public static bool operator +(Registro r,Jugadores j)
        {
            bool agregado = true;
            if(r.listaJugadores.Count > 0)
            {
               foreach(Jugadores jugador in r.listaJugadores)
               {
                    if (jugador.Equals(j))
                    {
                        agregado = false;
                        break;
                    }

               }
            }
          
            if (agregado || r.listaJugadores.Count == 0)
            {
                r.listaJugadores.Add(j);
                
            }
            return agregado;
        }

        public static bool operator -(Registro r,Jugadores j)
        {
            bool eliminado = false;
            if (r.listaJugadores.Count > 0)
            {
                foreach(Jugadores jugador in r.listaJugadores)
                {
                    if (jugador.Equals(j))
                    {
                        r.listaJugadores.Remove(jugador);
                        eliminado = true;
                        break;
                    }
                }
            }

            return eliminado;
        }
        /// <summary>
        /// ordena de forma ascendiente la lista segun los partidos jugados
        /// </summary>
        /// <param name="j1">primer jugador</param>
        /// <param name="j2">primer jugador</param>
        /// <returns>retorna -1 en donde indica que j1 va antes que j2 o si es 1 j2 tiene que ir antes que j1 en la lista</returns>
        public static int OrdenarPorPartidosJugadosAsc(Jugadores j1, Jugadores j2) // forma ascendente
        {
            if (j1.PartidosJugados < j2.PartidosJugados)
            {
                return -1;
            }
            else if (j1.PartidosJugados > j2.PartidosJugados)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// ordena de forma desdendiente la lista segun los partidos jugados
        /// </summary>
        /// <param name="j1">primer jugador</param>
        /// <param name="j2">segundo jugador</param>
        /// <returns>retora un numero en donde si es -1 j1 tiene que ir antes q j2 o si retorna 1 j2 tiene q ir antes q j1</returns>
        public static int OrdenarPorPartidosJugadosDes(Jugadores j1, Jugadores j2) // forma descendente
        {
            if (j1.PartidosJugados > j2.PartidosJugados)
            {
                return -1;
            }
            else if (j1.PartidosJugados < j2.PartidosJugados)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// ordena una lista de forma ascendente segun la edad q tengas
        /// </summary>
        /// <param name="j1">primer jugador</param>
        /// <param name="j2">primer jugador</param>
        /// <returns>retorna -1 en donde indica que j1 va antes que j2 o si es 1 j2 tiene que ir antes que j1 en la lista</returns>
        public static int OrdenarPorAñosAsc(Jugadores j1, Jugadores j2) // forma ascendente
        {
            if (j1.Años < j2.Años)
            {
                return -1;
            }
            else if (j1.Años > j2.Años)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// ordena una lista de forma ascendente segun la edad q tengas
        /// </summary>
        /// <param name="j1">primer jugador</param>
        /// <param name="j2">segundo jugador</param>
        /// <returns>retorna -1 en donde indica que j1 va antes que j2 o si es 1 j2 tiene que ir antes que j1 en la lista</returns>
        public static int OrdenarPorAñosDesc(Jugadores j1, Jugadores j2) // forma descendente
        {
            if (j1.Años > j2.Años)
            {
                return -1;
            }
            else if (j1.Años < j2.Años)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        
    }

    
}
