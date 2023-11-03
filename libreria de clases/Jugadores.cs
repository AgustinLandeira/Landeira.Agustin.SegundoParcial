using System.Text;
using System.Xml.Serialization;

namespace libreria_de_clases
{
    [XmlInclude(typeof(JugadorDeFutbol))]
    [XmlInclude(typeof(JugadorDeBasket))]
    [XmlInclude(typeof(JugadorDeBeisbol))]
    public abstract class Jugadores // clase base
    {
        public int partidosJugados;
        public string nombre;
        public string apellido;
        public short años;
        public EDeporte deporte;
        public int PartidosJugados
        {
            get { return this.partidosJugados;}
        }

        public string Nombre { get { return this.nombre;} }

        public string Apellido { get { return this.apellido;} }

        public short Años { get { return this.años; } }

        public EDeporte Deporte { get { return this.deporte; } }


        public Jugadores()
        {
            this.partidosJugados = 0;
            this.nombre = "indefinido";
            this.apellido = "indefinido";
            this.años = 0;
            this.deporte = EDeporte.Deportista;
        }

        public Jugadores(EDeporte deporte):this()
        {
            this.deporte = deporte;
        }
        public Jugadores(int partidosJugados, EDeporte deporte) :this(deporte)
        {
            this.partidosJugados = partidosJugados;
        }

        public Jugadores(int partidosJugados,string nombre, EDeporte deporte) :this(partidosJugados,deporte)
        {
            this.nombre = nombre;
        }

        public Jugadores(int partidosJugados, string nombre, string apellido, EDeporte deporte) : this(partidosJugados,nombre,deporte)
        {
            this.apellido = apellido;
        }
        /// <summary>
        /// se encarga de darle un valor al apellido y llamar a una sobrecarga para que siga dandole valores a los atributos
        /// </summary>
        /// <param name="partidosJugados"> son los partidos que se jugo</param>
        /// <param name="nombre"> el nombre del jugador</param>
        /// <param name="apellido"> el apellido del jugador</param>
        /// <param name="años">la edad que tiene</param>
        /// <param name="deporte">el tipo de deporte al que esta jugando</param>
        public Jugadores(int partidosJugados, string nombre, string apellido, short años, EDeporte deporte) 
            : this(partidosJugados, nombre, apellido,deporte)
        {
            this.años = años;
            
        }

        public abstract string CalcularPromedio(); // metodo abstracto de la clase base
        
        public virtual string Mostrar() // metodo virtual
        {
            return "Se desconoce las habilidades..";
            


        }
        /// <summary>
        /// se encarga a traves de un texto guardas los atributos que tendran todas las clases derivadas
        /// </summary>
        /// <returns> retorna un tipo string con los atributos</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"nombre: {this.Nombre} - apellido: {this.Apellido} -");
            sb.AppendLine($"años: {this.Años} - ");
            sb.AppendLine($"partidos jugados: {this.PartidosJugados} - ");
            sb.AppendLine($"deporte: {this.Deporte} ");

            return sb.ToString();
            
        }
    }
}