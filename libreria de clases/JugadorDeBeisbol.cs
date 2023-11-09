using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria_de_clases
{
    public class JugadorDeBeisbol:Jugadores,IPromedio // tercera clase derivada
    {
        public string accesorio;
        public int  vueltasMaximas;

        public string Accesorio
        {
            get { return this.accesorio; } 
        }

        public int VueltasMaximas
        {
            get { return this.vueltasMaximas; }
        }

        #region constructores

        public JugadorDeBeisbol():base()
        {
            this.accesorio = "se desconoce";
            this.vueltasMaximas = 0;
        }
        public JugadorDeBeisbol(int partidosJugados, string nombre, string apellido, short años, EDeporte deporte)
            :base(partidosJugados,nombre, apellido, años, deporte)
        {
            this.accesorio ="se desconoce";
            this.vueltasMaximas = 0;
        }
        public JugadorDeBeisbol(int vueltasMaximas, int partidosJugados, string nombre, string apellido, short años, EDeporte deporte)
            :this(partidosJugados,nombre, apellido, años, deporte)
        {
            this.vueltasMaximas = vueltasMaximas;

        }
        /// <summary>
        /// le da valor al atributo accesorio y llama al siguiente sobrecarga para seguir dandole valores a los atributos
        /// </summary>
        /// <param name="accesorio"> parte de una indumentaria del jugador de beisbol</param>
        /// <param name="vueltasMaximas">las vueltas que hizo en total en todos los partidos</param>
        /// <param name="partidosJugados">los partidos que jugo en total</param>
        /// <param name="nombre">nombre del jugador</param>
        /// <param name="apellido">apellido del jugador</param>
        /// <param name="años">edad el jugador</param>
        /// <param name="deporte">deporte que hace el jugador</param>
        public JugadorDeBeisbol(string accesorio, int vueltasMaximas, int partidosJugados, string nombre, string apellido, short años, EDeporte deporte) 
            :this(vueltasMaximas, partidosJugados,nombre, apellido, años, deporte)
        {
            this.accesorio = accesorio;
            
        }
        #endregion

        #region aplicando interfaz

        #endregion


        #region metodo abstracto y virtual
        /// <summary>
        /// calcula el promedio de las vueltas que hizo durante su carrera
        /// </summary>
        /// <returns>devuelve el promedio</returns>
        public override string CalcularPromedio()
        {
            float promedio = (float)this.vueltasMaximas / this.PartidosJugados;
            return promedio.ToString("0.00");
        }

        string IPromedio.CalcularPromedio()
        {
            float promedio = (float)this.vueltasMaximas / this.PartidosJugados;
            return promedio.ToString("0.00");
        }
        /// <summary>
        /// hace un texto de los atributos del jugador de beisbol
        /// </summary>
        /// <returns> lo retorna en forma de tipo string</returns>
        public override string Mostrar()
        {
            //return "se puede jugar con un bat y esta el conocido catcher que la puede agarrar con la mano si falla el del bat";
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($" - accesorio : {this.accesorio}-");
            sb.AppendLine($"vueltas maximas : {this.vueltasMaximas}-");
            sb.AppendLine($"promedio de vueltas: {((IPromedio)this).CalcularPromedio()}");

            return sb.ToString();
        }
        #endregion
        /// <summary>
        /// primero valida que el objeto sea del tipo jugador de beisbol y despues llama al operador ==
        /// </summary>
        /// <param name="obj">el objeto a comparar</param>
        /// <returns>retorna un booleano de la comparacion</returns>
        public override bool Equals(object? obj)
        {
            bool retorno = false;
            if (obj is JugadorDeBeisbol)
            {
                retorno = this == (JugadorDeBeisbol)obj;

            }else if (obj is JugadorDeBasket)
            {
                retorno = this == (JugadorDeBasket)obj;

            }else if (obj is JugadorDeFutbol)
            {
                retorno = this == (JugadorDeFutbol)obj;
            }

            return retorno;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #region
        /// <summary>
        /// compara si los nombre e apellidos de dos jugadores de beisbol son iguales
        /// </summary>
        /// <param name="j1">un jugador de beisbol</param>
        /// <param name="j2">un jugador de beisbol</param>
        /// <returns> retorna un booleano</returns>
        public static bool operator ==(JugadorDeBeisbol j1, JugadorDeBeisbol j2)
        {
            return ((IJugador)j1).Nombre == ((IJugador)j2).Nombre && ((IJugador)j1).Apellido == ((IJugador)j2).Apellido;
        }
        /// <summary>
        /// llama al operador ==
        /// </summary>
        /// <param name="j1">un jugador de beisbol</param>
        /// <param name="j2">un jugador de beisbol</param>
        /// <returns>retorna lo contrario de lo que devuelva el operador ==</returns>
        public static bool operator !=(JugadorDeBeisbol j1, JugadorDeBeisbol j2)
        {
            return !(j1 == j2);
        }
        /// <summary>
        /// compara si los nombre e apellidos de dos jugadores de distinto deporte son iguales
        /// </summary>
        /// <param name="j1">un jugador de beisbol</param>
        /// <param name="j2">un jugador de futbol</param>
        /// <returns>devuelve un booleano</returns>
        public static bool operator ==(JugadorDeBeisbol j1, JugadorDeFutbol j2)
        {
            return ((IJugador)j1).Nombre == ((IJugador)j2).Nombre && ((IJugador)j1).Apellido == ((IJugador)j2).Apellido;
        }
        /// <summary>
        /// llama e invoca al operador ==
        /// </summary>
        /// <param name="j1">un jugador de beisbol</param>
        /// <param name="j2">un jugador de futbol</param>
        /// <returns>devuelve lo contrario a lo que devuelva el operador ==</returns>
        public static bool operator !=(JugadorDeBeisbol j1, JugadorDeFutbol j2)
        {
            return !(j1 == j2);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="j1">un jugador de beisbol</param>
        /// <param name="j2">un jugador de basket</param>
        /// <returns>devuelve booleano si en la comparacion los dos atributos son iguales</returns>
        public static bool operator ==(JugadorDeBeisbol j1, JugadorDeBasket j2)
        {
            return ((IJugador)j1).Nombre == ((IJugador)j2).Nombre && ((IJugador)j1).Apellido == ((IJugador)j2).Apellido;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="j1">un jugador de beisbol</param>
        /// <param name="j2">un jugador de basket</param>
        /// <returns>devuelve lo contrario de lo que recibe el operador ==</returns>
        public static bool operator !=(JugadorDeBeisbol j1, JugadorDeBasket j2)
        {
            return !(j1 == j2);
        }
        #endregion
        #region sobrecarga de operador implicito


        public static implicit operator JugadorDeBeisbol(string proteccion)
        {

            return new JugadorDeBeisbol(proteccion, 12, 11, "lucas", "allen", 29, EDeporte.Beisbol);
        }

        public static implicit operator JugadorDeBeisbol(int vueltas)
        {

            return new JugadorDeBeisbol("casco", vueltas, 11, "indiana", "jones", 29, EDeporte.Beisbol);
        }

        public static implicit operator JugadorDeBeisbol(EDeporte deporte)// inplicita
        {

            return new JugadorDeBeisbol("casco", 14, 11, "cisco", "ramon", 29,deporte);
        }

        #endregion


        /// <summary>
        /// invoca el metodo virtual llamado mostrar
        /// </summary>
        /// <returns>devuelve lo que devuelva el metodo al cual esta llamando</returns>
        public override string ToString()
        {

            return this.Mostrar();
        }

    }
}
