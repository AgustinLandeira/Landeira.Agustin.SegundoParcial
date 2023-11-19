using libreria_de_clases;
using System;
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
    public partial class FmrBasket : Form
    {
        public JugadorDeBasket Jugador;
        private Validacion validacion;

        /// <summary>
        /// recupera los datos que habia ingresado anteriormente el usuario del jugador que creo
        /// </summary>
        /// <param name="jug">el jugador de basket que habiamos instanciado</param>
        public FmrBasket(JugadorDeBasket jug) : this()
        {
            this.txtApellidoBasket.Text = ((IJugador)jug).Apellido;
            this.txtNombreBasket.Text = ((IJugador)jug).Nombre;
            this.txtPartidosBasket.Text = jug.PartidosJugados.ToString();
            this.txtEdadBasket.Text = jug.Años.ToString();
            this.txtPuntos.Text = jug.Puntos.ToString();
            this.txtObjetivo.Text = jug.Objetivo;
            this.DialogResult = DialogResult.OK;
        }
        public FmrBasket()
        {
            this.validacion = new Validacion();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        /// <summary>
        /// primero valida que los datos esten okey y se instancia  el nuevo jugador a traves de los datos que le dimos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptarBasket_Click(object sender, EventArgs e)
        {
            short años;
            int partidos;
            int puntos;

            string nombre = this.txtNombreBasket.Text;
            string apellido = this.txtApellidoBasket.Text;
            string objetivo = this.txtObjetivo.Text;


            if (short.TryParse(this.txtEdadBasket.Text, out años) && int.TryParse(this.txtPuntos.Text, out puntos) &&
                int.TryParse(this.txtPartidosBasket.Text, out partidos))
            {
                this.validacion.EdadIngresada = años;
                this.validacion.PartidosJugados = partidos;
                this.validacion.Goles_Puntos_Vueltas = puntos;
                if (this.validacion.EdadIngresada > 0 && this.validacion.PartidosJugados >= 0 &&
                    this.validacion.Goles_Puntos_Vueltas >= 0)
                {
                    this.Jugador = new JugadorDeBasket(puntos, objetivo, partidos, nombre, apellido, años, EDeporte.Basquet);
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
