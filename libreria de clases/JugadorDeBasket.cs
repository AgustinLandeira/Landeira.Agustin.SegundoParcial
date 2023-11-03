using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria_de_clases
{
    public class JugadorDeBasket:Jugadores // primera clase derivada
    {
        public int puntos;
        public string objetivo;

        public int Puntos
        {
            get { return this.puntos; }
        }

        public string Objetivo
        {
            get { return this.objetivo; }
        }
        #region constructores

        public JugadorDeBasket() : base()
        {
            this.puntos = 0;
            this.objetivo = "no se sabe";
        }
        JugadorDeBasket(int partidosJugados, string nombre, string apellido, short años,EDeporte deporte) 
            :base(partidosJugados, nombre, apellido, años,deporte) 
        { 
            this.puntos = 0;
            this.objetivo = "no se sabe";
        
        }
        public JugadorDeBasket(int puntos, int partidosJugados, string nombre, string apellido, short años, EDeporte deporte) 
            :this(partidosJugados, nombre, apellido, años,deporte)
        {
            this.puntos = puntos;
            
        }
        /// <summary>
        /// le da valor al atributo objetivo y despues llama a las sobrecargas para seguir dandole valores a los atributos
        /// </summary>
        /// <param name="puntos">los puntos que hixo el jugador</param>
        /// <param name="objetivo">el objetivo que tiene el jugador de basket</param>
        /// <param name="partidosJugados">los partidos que jugo el en total el jugador</param>
        /// <param name="nombre"> el nombre del jugador</param>
        /// <param name="apellido"> el apellido del jugador</param>
        /// <param name="años">la edad del jugador</param>
        /// <param name="deporte">el deporte que estacion</param>
        public JugadorDeBasket(int puntos, string objetivo, int partidosJugados, string nombre, string apellido, short años, EDeporte deporte) 
            : this(puntos, partidosJugados, nombre, apellido, años,deporte)
        {
            this.objetivo = objetivo;
        }
        #endregion
        /// <summary>
        /// este metodo calcula el promedio de cuantos puntos x partido hace el jugador de basket
        /// </summary>
        /// <returns> retorna el promedio con dos decimales </returns>
        public override string CalcularPromedio()
        {
            float promedio = (float)this.puntos / this.PartidosJugados;
            return promedio.ToString("0.00");

        }

        #region sobrecarga de operador implicito

        public static implicit operator JugadorDeBasket(int puntos)
        {

            return new JugadorDeBasket(puntos, "aro", 12, "lauty", "primi", 23, EDeporte.Basquet);
        }

        public static implicit operator JugadorDeBasket(string objetivo)// inplicita
        {

            return new JugadorDeBasket(300, objetivo, 12, "lauty", "primi", 23, EDeporte.Basquet);
        }


        public static implicit operator JugadorDeBasket(EDeporte deporte)// inplicita
        {

            return new JugadorDeBasket(300, "aro", 12, "mauro", "hry", 23, deporte);
        }

        #endregion

        /// <summary>
        /// muestra la informacion del jugador de basket con sus caracteristicas definidas
        /// </summary>
        /// <returns> retorna un texto que lo pasamos a string </returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"puntos: {this.puntos}-");
            sb.AppendLine($"objetivo : {this.objetivo}-");
            sb.AppendLine($"promedio de puntos {this.CalcularPromedio()}");

            return sb.ToString();

        }
        /// <summary>
        /// llama al operador == para comparar los dos objetos
        /// </summary>
        /// <param name="obj">seria el objeto a comparar</param>
        /// <returns>retorna un true si se encuentra una coincidencia con la comparacion</returns>
        public override bool Equals(object? obj)
        {
            bool retorno = false;
            if (obj is JugadorDeBasket)
            {
                retorno = this == (JugadorDeBasket)obj;

            } else if (obj is JugadorDeFutbol)
            {
                retorno = this == (JugadorDeFutbol)obj;

            } else if (obj is JugadorDeBeisbol)
            {
                retorno = this == (JugadorDeBeisbol)obj;
            }

            return retorno;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #region operadores
        /// <summary>
        /// se compara entre dos jugadores de basket si tiene los mismos nombres e apellidos
        /// </summary>
        /// <param name="j1">seria el primer jugador de basket</param>
        /// <param name="j2">seria el segundo jugar de basket</param>
        /// <returns>retorna un true si tienen los mismo datos o de lo contrario un false</returns>
        public static bool operator ==(JugadorDeBasket j1, JugadorDeBasket j2)
        {
            return j1.Nombre == j2.Nombre && j1.Apellido == j2.Apellido;
        }
        /// <summary>
        /// te invoca el operador ==
        /// </summary>
        /// <param name="j1">seria el primer jugador de basket</param>
        /// <param name="j2">seria el segundo jugar de basket</param>
        /// <returns>te devuelve el bool contrario a lo que te devuelva el operador ==</returns>
        public static bool operator !=(JugadorDeBasket j1, JugadorDeBasket j2)
        {
            return !(j1 == j2);
        }
        /// <summary>
        /// se compara entre dos jugadores de distintos deportes  si tienen los mismos nombres e apellidos
        /// </summary>
        /// <param name="j1">seria el primer jugador de basket</param>
        /// <param name="j2">seria el segundo jugar de futbol</param>
        /// <returns>retorna un true si tienen los mismo datos o de lo contrario un false</returns>
        public static bool operator ==(JugadorDeBasket j1, JugadorDeFutbol j2)
        {
            return j1.Nombre == j2.Nombre && j1.Apellido == j2.Apellido;
        }

        /// <summary>
        /// invoca al operador ==
        /// </summary>
        /// <param name="j1">seria el primer jugador de basket</param>
        /// <param name="j2">seria el segundo jugadorr de futbol</param>
        /// <returns>te devuelve el bool contrario a lo que te devuelva el operador ==</returns>
        public static bool operator !=(JugadorDeBasket j1, JugadorDeFutbol j2)
        {
            return !(j1 == j2);
        }
        /// <summary>
        /// se compara entre dos jugadores de distinto deporte si tiene los mismos nombres e apellidos
        /// </summary>
        /// <param name="j1">seria el primer jugador de basket</param>
        /// <param name="j2">seria el segundo jugar de beisbol</param>
        /// <returns>retorna un true si tienen los mismo datos o de lo contrario un false</returns>
        public static bool operator ==(JugadorDeBasket j1, JugadorDeBeisbol j2)
        {
            return j1.Nombre == j2.Nombre && j1.Apellido == j2.Apellido;
        }
        /// <summary>
        /// invoca al operador ==
        /// </summary>
        /// <param name="j1">seria el primer jugador de basket</param>
        /// <param name="j2">seria el segundo jugadorr de beisbol</param>
        /// <returns>te devuelve el bool contrario a lo que te devuelva el operador ==</returns>
        public static bool operator !=(JugadorDeBasket j1, JugadorDeBeisbol j2)
        {
            return !(j1 == j2);
        }
        #endregion

        /// <summary>
        /// invoca al metodo tostring
        /// </summary>
        /// <returns>retorna lo que retorne ese metodo al que esta llamando</returns>
        public override string ToString()
        {
            return this.Mostrar();
            
        }
    }
}
