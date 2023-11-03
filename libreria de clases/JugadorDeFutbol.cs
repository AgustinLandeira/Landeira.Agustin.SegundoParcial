using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace libreria_de_clases
{
    
    public class JugadorDeFutbol:Jugadores // segunda clase derivada
    {
        public short goles;
        public string posicion;

        // sobreecarga elegida

        public short Goles
        {
            get { return this.goles; }
        }

        public string Posicion
        {
            get { return this.posicion; }
        }
        /// <summary>
        /// llama a la clase base y sus propios atributos les da un valor por defecto
        /// </summary>
        public JugadorDeFutbol():base()
        {
            this.goles = 0;
            this.posicion = "desconocida";
        }

        #region contructores
        public JugadorDeFutbol(int partidosJugados, string nombre, string apellido, short años, EDeporte deporte) :base(partidosJugados, nombre, apellido,años, deporte) 
        {
            this.goles = 0;
            this.posicion = "desconocida";
        }

        public JugadorDeFutbol(short cantGoles, int partidosJugados, string nombre, string apellido, short años,EDeporte deporte)
            :this(partidosJugados, nombre, apellido, años,deporte)
        {
            this.goles = cantGoles;
            
        }
        /// <summary>
        /// este metodo le da valor al atributo posicion y a su vez llama a la sobrecarga para seguir dandole los valores a los atributos
        /// </summary>
        /// <param name="cantGoles">la cantidad de goles del jugador</param>
        /// <param name="posicion">la posicion del que juega el jugador</param>
        /// <param name="partidosJugados"></param>
        /// <param name="nombre"> el nombre del jugador</param>
        /// <param name="apellido"> el apellido del jugador</param>
        /// <param name="años">la edad que tiene el jugador</param>
        /// <param name="deporte"> el tipo de deporte que juega</param>
        public JugadorDeFutbol(short cantGoles, string posicion, int partidosJugados, string nombre, string apellido, short años,EDeporte deporte) 
            :this(cantGoles, partidosJugados, nombre, apellido, años,deporte)
        {
            this.posicion = posicion;
        }

        #endregion

        /// <summary>
        /// este metodo se encarga de calcular el promedio de la cantidad de goles x partido del futbolista
        /// </summary>
        /// <returns> retorna el promedio del jugador con dos decimales</returns>
        public override string CalcularPromedio()
        {
            float promedio = (float)this.goles / this.PartidosJugados;
            return promedio.ToString("0.00");
        }

        /// <summary>
        /// este metodo se encargar de hacer un texto y conseguir los atributos del jugador
        /// </summary>
        /// <returns> retorna la info del jugador</returns>
        public override string Mostrar()
        {
            //return "Se juega con los pies y soo el arquero puede tocarla con la mano";
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"- goles: {this.goles} - ");
            sb.AppendLine($"posicion: {this.posicion} - ");
            sb.AppendLine($"promedio de goles: {this.CalcularPromedio()}");

            return sb.ToString();
        }

        /// <summary>
        /// este metodo llama al operador == para comparar segun la condicion que le des
        /// </summary>
        /// <param name="obj">le estariamos pasando la instancia a comparar</param>
        /// <returns>devuelve true si la comparacion dio resultado</returns>
        public override bool Equals(object? obj)
        {
            bool retorno = false;
            if (obj is JugadorDeFutbol)
            {
                retorno = this == (JugadorDeFutbol)obj;

            }else if(obj is JugadorDeBasket)
            {
                retorno = this == (JugadorDeBasket)obj;
            }else if(obj is JugadorDeBeisbol)
            {
                retorno = this == (JugadorDeBeisbol)obj;
            }
           
            
            return retorno;
        }

        #region operadores

        /// <summary>
        /// compara el nombre y apellido de dos jugadores
        /// </summary>
        /// <param name="j1">seria el primer  jugador de futbol</param>
        /// <param name="j2">seria el segundo  jugador de futbol</param>
        /// <returns>te devuelve true si la comparacion da resultado de lo contrario un false</returns>
        public static bool operator ==(JugadorDeFutbol j1, JugadorDeFutbol j2)
        {
            return j1.Nombre == j2.Nombre && j1.Apellido == j2.Apellido;
        }

        /// <summary>
        /// devuelve lo contrario a lo que devuelva el operado == si te devuelve un true entonces eria un falso
        /// </summary>
        /// <param name="j1">seria el primer  jugador de futbol</param>
        /// <param name="j2">seria el segundo  jugador de futbol</param>
        /// <returns>te devuelve un false si es true o al reves</returns>
        public static bool operator !=(JugadorDeFutbol j1, JugadorDeFutbol j2)
        {
            return !(j1 == j2);
        }

        /// <summary>
        /// compara el nombre y apellido de dos jugadores pero de distinto deporte
        /// </summary>
        /// <param name="j1">seria el primer  jugador de futbol</param>
        /// <param name="j2">seria el segundo  jugador de basket</param>
        /// <returns>te devuelve true si la comparacion da resultado de lo contrario un false</returns>
        public static bool operator ==(JugadorDeFutbol j1, JugadorDeBasket j2)
        {
            return j1.Nombre == j2.Nombre && j1.Apellido == j2.Apellido;
        }

        /// <summary>
        /// devuelve lo contrario a lo que devuelva el operado == si te devuelve un true entonces seria un falso
        /// </summary>
        /// <param name="j1">seria el primer  jugador de futbol</param>
        /// <param name="j2">seria el segundo  jugador de basket</param>
        /// <returns>te devuelve un false si es true o al reves</returns>
        public static bool operator !=(JugadorDeFutbol j1, JugadorDeBasket j2)
        {
            return !(j1 == j2);
        }

        /// <summary>
        /// compara el nombre y apellido de dos jugadores pero de distinto deporte
        /// </summary>
        /// <param name="j1">seria el primer  jugador de futbol</param>
        /// <param name="j2">seria el segundo  jugador de beisbol</param>
        /// <returns>te devuelve true si la comparacion da resultado de lo contrario un false</returns>
        public static bool operator ==(JugadorDeFutbol j1, JugadorDeBeisbol j2)
        {
            return j1.Nombre == j2.Nombre && j1.Apellido == j2.Apellido;
        }

        /// <summary>
        ///  devuelve lo contrario a lo que devuelva el operado == si te devuelve un true entonces seria un falso
        /// </summary>
        /// <param name="j1">seria el primer  jugador de futbol</param>
        /// <param name="j2">seria el segundo  jugador de beisbol</param>
        /// <returns>te devuelve un false si es true o al reves</returns>
        public static bool operator !=(JugadorDeFutbol j1, JugadorDeBeisbol j2)
        {
            return !(j1 == j2);
        }
        #endregion
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #region sobrecarga de operador implicito
        public static implicit operator JugadorDeFutbol(short cantidadGoles)// inplicita
        {
           
            return new JugadorDeFutbol(cantidadGoles, "Delantero", 10, "Nombre", "Apellido", 0, EDeporte.Futbol);
        }

        public static implicit operator JugadorDeFutbol(string posicion)// inplicita
        {

            return new JugadorDeFutbol(12, posicion, 11, "Nombre", "Apellido", 19, EDeporte.Futbol);
        }


        public static implicit operator JugadorDeFutbol(EDeporte deporte)// inplicita
        {

            return new JugadorDeFutbol(33, "Delantero", 21, "juan", "landeira", 12,deporte);
        }

        #endregion

        /// <summary>
        /// llama al metodo virtual llamado mostrar
        /// </summary>
        /// <returns>retorna lo que tenga el virtual</returns>
        public override string ToString()
        {
            
            return this.Mostrar();
        }


    }
}
