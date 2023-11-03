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
    public partial class FmrOpciones : Form
    {
        public JugadorDeFutbol futbolista;
        public JugadorDeBasket basketbolista;
        public JugadorDeBeisbol beisbolista;
        public bool esBasket;
        public bool esFutbol;
        public bool esBeisbol;
        public FmrOpciones()
        {
            this.esBasket = false;
            this.esFutbol = false;
            this.esBeisbol = false;
            InitializeComponent();
        }

        /// <summary>
        /// se encarga llamar al formulario del jugador para ponerle los datos si el usuario elige juagdor de futbol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFutbolista_Click(object sender, EventArgs e)
        {
            FmrFutbol fmrFutbolista = new FmrFutbol();

            //fmrFutbolista.StartPosition = FormStartPosition.CenterScreen;

            fmrFutbolista.ShowDialog();

            this.esFutbol = true;
            if (fmrFutbolista.DialogResult == DialogResult.OK)
            {
                this.futbolista = fmrFutbolista.Jugador;
                this.DialogResult = DialogResult.OK;


            }



        }

        /// <summary>
        /// se encarga llamar al formulario del jugador para ponerle los datos si el usuario elige juagdor de basket
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBasketbolista_Click(object sender, EventArgs e)
        {

            FmrBasket fmrBasketbolista = new FmrBasket();
           

            fmrBasketbolista.ShowDialog();
            this.esBasket = true;

            if (fmrBasketbolista.DialogResult == DialogResult.OK)
            {
                this.basketbolista = fmrBasketbolista.Jugador;
                this.DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// se encarga llamar al formulario del jugador para ponerle los datos si el usuario elige juagdor de beisbol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBeisbolista_Click(object sender, EventArgs e)
        {
            FmrBeisbol beisbol = new FmrBeisbol();

           
            beisbol.ShowDialog();
            this.esBeisbol = true;

            if (beisbol.DialogResult == DialogResult.OK)
            {
                this.beisbolista = beisbol.jugador;
                this.DialogResult = DialogResult.OK;
            }

        }
    }
}
