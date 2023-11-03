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
    public partial class FmrBeisbol : Form
    {
        public JugadorDeBeisbol jugador;

        /// <summary>
        /// recupera los datos que habia puesto el usuario anteriormente
        /// </summary>
        /// <param name="prod">el jugador de beisbol que habiamos instanciado</param>
        public FmrBeisbol(JugadorDeBeisbol prod) : this()
        {
            this.txtApellidoBeisbol.Text = prod.Apellido;  
            this.txtNombreBeisbol.Text = prod.Nombre;
            this.txtPartidosBeisbol.Text = prod.PartidosJugados.ToString();
            this.txtEdadBeisbol.Text = prod.Años.ToString();
            this.txtcantVueltas.Text = prod.VueltasMaximas.ToString();
            this.txtAccesorio.Text = prod.Accesorio;
            this.DialogResult = DialogResult.OK;
        }
        public FmrBeisbol()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        /// <summary>
        /// primero valida que los datos ingresados esten ok y instanciamos el jugador de beisbol a traves de los valores que le dimos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptarBeisbol_Click(object sender, EventArgs e)
        {
            short años;
            int vueltas;
            int partidos;

            string nombre = this.txtNombreBeisbol.Text;
            string apellido = this.txtApellidoBeisbol.Text;
            string acceorio = this.txtAccesorio.Text;


            if(short.TryParse(this.txtEdadBeisbol.Text,out años) && int.TryParse(this.txtcantVueltas.Text,out vueltas) &&
                int.TryParse(this.txtPartidosBeisbol.Text,out partidos))
            {
                this.jugador = new JugadorDeBeisbol(acceorio, vueltas, partidos, nombre, apellido, años, EDeporte.Beisbol);

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("ERROR CON LA ENTRADA DE DATOS", "ADVERTENCIA!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
