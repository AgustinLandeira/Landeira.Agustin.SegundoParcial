using libreria_de_clases;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario_login_
{
    public partial class FmrFutbol : Form
    {
        public JugadorDeFutbol Jugador;
        private List<JugadorDeFutbol> jugadoresDeFutbol;
        private Validacion validacion;

        /// <summary>
        /// recupera los datos que habia puesto el usuario anteriormente
        /// </summary>
        /// <param name="prod">el jugador de futbol que habiamos instanciado</param>
        public FmrFutbol(JugadorDeFutbol prod) : this()
        {
            this.txtApellido.Text = ((IJugador)prod).Apellido;
            this.txtNombre.Text = ((IJugador)prod).Nombre;
            this.txtPartidosJugados.Text = prod.PartidosJugados.ToString();
            this.txtAño.Text = prod.Años.ToString();
            this.txtCantGoles.Text = prod.Goles.ToString();
            this.txtPosicion.Text = prod.Posicion;
            this.DialogResult = DialogResult.OK;
            
            
        }
        public FmrFutbol()
        {
             this.validacion = new Validacion();
            this.jugadoresDeFutbol = new List<JugadorDeFutbol>();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        /// <summary>
        /// primero valida que los datos esten bien y despues se crea el nuevo jugador a traves de los valores que le dimos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            int partidos;
            short años;
            short goles;

            string nombre = this.txtNombre.Text;
            string apellido = this.txtApellido.Text;
            string posicion = this.txtPosicion.Text;

            if(int.TryParse(this.txtPartidosJugados.Text,out partidos) && short.TryParse(this.txtAño.Text,out años)
                && short.TryParse(this.txtCantGoles.Text,out goles))   
            {
                this.validacion.EdadIngresada = años;
                this.validacion.PartidosJugados = partidos;
                this.validacion.Goles_Puntos_Vueltas = goles;

                if (this.validacion.EdadIngresada > 0 && this.validacion.PartidosJugados >= 0 &&
                    this.validacion.Goles_Puntos_Vueltas >= 0)
                {
                    this.Jugador = new JugadorDeFutbol(goles, posicion, partidos, nombre, apellido, años, EDeporte.Futbol);
                    this.DialogResult = DialogResult.OK;

                }
                
                
   
            }
            else
            {
                MessageBox.Show("ERROR CON LA ENTRADA DE DATOS", "ADVERTENCIA!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }
    }
}
