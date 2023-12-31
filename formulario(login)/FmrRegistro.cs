﻿using libreria_de_clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Threading;

namespace formulario_login_
{
    public partial class FmrRegistro : Form
    {
        private List<Jugadores> jugadores;
        private Login logeado;
        private Registro<Jugadores> registro;
        private AccesoDatos ado;
        private string nombreOriginal;
        private string apellidoOriginal;
        private Notificaciones validar;
        private CancellationToken cancellation;
        private CancellationTokenSource cancellationSource;
        private Task cronometroTask;
        private TimeSpan tiempoTranscurrido;


        /// <summary>
        /// crea una instancia 
        /// </summary>
        /// <param name="login">se pasa el objeto del tipo login y lo instanciamos para que tenga el coportamiento que tuvo</param>
        public FmrRegistro(Login login)
        {

            this.ado = new AccesoDatos();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.jugadores = new List<Jugadores>();
            InitializeComponent();
            this.logeado = login;
            this.registro = new Registro<Jugadores>();
            this.validar = new Notificaciones();
            this.cancellationSource = new CancellationTokenSource();//hace el cancel
            this.cancellation = this.cancellationSource.Token;// verifica si se quiere cancelar
            this.tiempoTranscurrido = TimeSpan.Zero; // es una constante en que representa 0 horas,0minutos,0segundos etc

            EmpezarCronometro();
        }

        /// <summary>
        /// crea el hilo y se ejecuta en segundo plano mientras no se cancele
        /// </summary>
        private void EmpezarCronometro()
        {
            // con el task.run realizo la tarea en segundo plano
            this.cronometroTask = Task.Run(async () => // utilizamos una expresion labda para realizar la tarea
            {
                while (!this.cancellation.IsCancellationRequested) // este bucle se itera mientra el la cancelacion no fue pedida 
                {
                    // al usar async nos permite usar el await que lo usamos de forma asincronica para pausar la ejecucuion
                    await Task.Delay(1000); // Espera 1 segundo de forma asincronica
                    tiempoTranscurrido = tiempoTranscurrido.Add(TimeSpan.FromSeconds(1));// en cada iteracion el cronometro va incrementando en 1

                    // Actualiza el Label con el tiempo transcurrido
                    ActualizarTiempoTranscurrido(tiempoTranscurrido);
                }
            }, this.cancellation);
        }

        /// <summary>
        /// se encarga de mostrar el cronometro en un formato especifico
        /// </summary>
        /// <param name="tiempo"></param>
        private void ActualizarTiempoTranscurrido(TimeSpan tiempo)
        {

            if (InvokeRequired)
            {
                //invocamos la actualización en el hilo de la interfaz de usuario
                Invoke(new Action(() => ActualizarTiempoTranscurrido(tiempo)));
            }
            else
            {
                // Si estamos en el hilo de la interfaz, actualizar directamente el Label
                this.lblTiempo.Text = $"{tiempo.Hours:D2}:{tiempo.Minutes:D2}:{tiempo.Seconds:D2}";
                // el formato d2 es par que me muestre dos digitos
            }
        }

        /// <summary>
        /// muestra  una notficacion sobre el uso de los perfiles
        /// </summary>
        /// <param name="notificacion"></param>

        public static void Notificar(string notificacion)
        {
            MessageBox.Show(notificacion, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        /// <summary>
        /// muestra el nombre del jugador que ya se agrego
        /// </summary>
        /// <param name="nombre"></param>
        public static void MostrarJugadorRepetido(string nombre)
        {
            MessageBox.Show(nombre, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// muestra un mensaje si se recibe un entero menor de 0
        /// </summary>
        /// <param name="mensaje"></param>
        public static void EdadInvalida(string mensaje)
        {
            MessageBox.Show(mensaje, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// te va agregando a la lstbox los jugadores que esta en la lista
        /// </summary>
        private void ActualizarRegistro()
        {
            this.lstRegistro.Items.Clear();

            foreach (Jugadores jugador in this.registro.ListaJugadores)
            {
                lstRegistro.Items.Add(jugador.ToString());

            }


        }
        /// <summary>
        /// verifica el tipo de deporte al que juega el jugador y lo agrega
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (this.logeado.perfil == "administrador" || this.logeado.perfil == "supervisor")
            {
                FmrOpciones fmrOpciones = new FmrOpciones();
                fmrOpciones.StartPosition = FormStartPosition.CenterScreen;

                fmrOpciones.ShowDialog();


                if (fmrOpciones.esFutbol)
                {
                    if (fmrOpciones.DialogResult == DialogResult.OK)
                    {
                        if (this.registro + fmrOpciones.futbolista)
                        {
                            this.ActualizarRegistro();
                            this.ado.AgregarJugadorTabla(fmrOpciones.futbolista);
                        }
                        else
                        {
                            this.validar.NombreJugador = fmrOpciones.futbolista.nombre;

                        }


                    }
                }
                else if (fmrOpciones.esBasket)
                {
                    if (fmrOpciones.DialogResult == DialogResult.OK)
                    {
                        if (this.registro + fmrOpciones.basketbolista)
                        {
                            this.ActualizarRegistro();
                            this.ado.AgregarJugadorTabla(fmrOpciones.basketbolista);
                        }
                        else
                        {
                            this.validar.NombreJugador = fmrOpciones.basketbolista.nombre;
                        }


                    }
                }
                else if (fmrOpciones.esBeisbol)
                {
                    if (fmrOpciones.DialogResult == DialogResult.OK)
                    {
                        if (this.registro + fmrOpciones.beisbolista)
                        {
                            this.ActualizarRegistro();
                            this.ado.AgregarJugadorTabla(fmrOpciones.beisbolista);
                        }
                        else
                        {
                            this.validar.NombreJugador = fmrOpciones.beisbolista.nombre;
                        }


                    }
                }

            }
            else
            {
                this.validar.Profesion = this.logeado.perfil;

            }



        }
        /// <summary>
        /// se encarga de verificar que tipo de jugador queres modificar y llama a un metodo para que termine de hacerlo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.logeado.perfil == "administrador" || this.logeado.perfil == "supervisor")
            {
                int indice = this.lstRegistro.SelectedIndex;

                if (indice == -1)
                {
                    return;
                }

                Jugadores jugadorAModificar = this.registro.ListaJugadores[indice];
                this.nombreOriginal = ((IJugador)jugadorAModificar).Nombre;
                this.apellidoOriginal = ((IJugador)jugadorAModificar).Apellido;

                if (jugadorAModificar is JugadorDeFutbol)
                {
                    JugadorDeFutbol futbolista = (JugadorDeFutbol)jugadorAModificar;
                    FmrFutbol fmrf = new FmrFutbol(futbolista);

                    this.ModificarJugador(fmrf, indice);


                }
                else if (jugadorAModificar is JugadorDeBasket)
                {
                    JugadorDeBasket basketbolista = (JugadorDeBasket)jugadorAModificar;
                    FmrBasket fmrba = new FmrBasket(basketbolista);
                    this.ModificarJugadorBasket(fmrba, indice);

                }
                else
                {
                    JugadorDeBeisbol beisbolista = (JugadorDeBeisbol)jugadorAModificar;
                    FmrBeisbol fmrbe = new FmrBeisbol(beisbolista);
                    this.ModificarJugadorBeisbol(fmrbe, indice);
                }
            }
            else
            {
                this.validar.Profesion = this.logeado.perfil;
            }

        }
        /// <summary>
        /// verifica que tipo de jugador queres eliminar y llama al metodo para que termine de eliminarlo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (this.logeado.perfil == "administrador")
            {
                int indice = this.lstRegistro.SelectedIndex;

                if (indice == -1)
                {
                    return;
                }

                Jugadores claseJugador = this.registro.ListaJugadores[indice];

                DialogResult rta = MessageBox.Show("¿estas seguro de liminar este jugador del registro? ", "ATENCION", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question);

                if (rta == DialogResult.Yes && this.registro - claseJugador)
                {
                    ado.EliminarFila(claseJugador);
                    this.ActualizarRegistro();
                }
                else
                {
                    MessageBox.Show("no se pudo eliminar el jugador", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.validar.Profesion = this.logeado.perfil;

            }



        }
        #region RECUPERAR Y GUARDAR DATOS EN XML
        /// <summary>
        /// te guarda la coleccion generica en forma xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            if(this.logeado.perfil == "")
            {

                try
                {
                    SaveFileDialog guardarDatos = new SaveFileDialog();


                    if (guardarDatos.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = guardarDatos.FileName;
                        using (XmlTextWriter escritorxml = new XmlTextWriter(filePath, Encoding.UTF8))
                        {
                            XmlSerializer serializador = new XmlSerializer(typeof(List<Jugadores>));
                            serializador.Serialize(escritorxml, this.registro.ListaJugadores);
                            MessageBox.Show(" SE PUDO GUARDAR LOS DATOS", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show(" EN ESTA PARTE DEL PARCIAL NO ESTA DISPONIBLE ESTE BOTON", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        /// <summary>
        /// te recupera la coleccion generica de la ultima vez que hayas guardado los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecuperarDatos_Click(object sender, EventArgs e)
        {
            if(this.logeado.perfil == "")
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    Xml xml = new Xml();
                    try
                    {
                        this.registro.ListaJugadores = xml.Deserializar(filePath);
                        this.ActualizarRegistro();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hubo un error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            else
            {
                MessageBox.Show(" EN ESTA PARTE DEL PARCIAL NO ESTA DISPONIBLE ESTE BOTON", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }
        #endregion

        #region ORDENAR REGISTRO DE FORMA ASCENDENTE O DESCENDENTE
        /// <summary>
        /// dependiento de la opcion que eligas te lo ordena de forma ascendente y descendente segun edad o partidos jugados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (this.BtnRadioEdadAsc.Checked == true)
            {
                this.registro.ListaJugadores.Sort(Registro<Jugadores>.OrdenarPorAñosAsc);
                ActualizarRegistro();

            }
            else if (this.BtnRadioEdadDesc.Checked == true)
            {
                this.registro.ListaJugadores.Sort(Registro<Jugadores>.OrdenarPorAñosDesc);
                ActualizarRegistro();

            }
            else if (this.BtnRadioPartAsc.Checked == true)
            {
                this.registro.ListaJugadores.Sort(Registro<Jugadores>.OrdenarPorPartidosJugadosAsc);
                ActualizarRegistro();
            }
            else
            {
                this.registro.ListaJugadores.Sort(Registro<Jugadores>.OrdenarPorPartidosJugadosDes);
                ActualizarRegistro();
            }
        }
        #endregion

        /// <summary>
        /// recupera el nombre del usuario y lo muestra arriba del formulario junto con la fecha actual en el cual inicio la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FmrRegistro_Load(object sender, EventArgs e)
        {

            this.Text = "Operador: " + logeado.nombreUsuario + " - fecha actual: " + DateTime.Now.ToShortDateString();
            this.registro.ListaJugadores = this.ado.RecuperarInformacion(this.registro.ListaJugadores, true, false, false);
            this.registro.ListaJugadores = this.ado.RecuperarInformacion(this.registro.ListaJugadores, false, true, false);
            this.registro.ListaJugadores = this.ado.RecuperarInformacion(this.registro.ListaJugadores, false, false, true);
            ActualizarRegistro();
        }

        /// <summary>
        /// te muestra el form del jugador de futbol y te da la oputunidad de modificar sus caracteristicas
        /// </summary>
        /// <param name="fmr"></param>
        /// <param name="indice"></param>
        private void ModificarJugador(FmrFutbol fmr, int indice)
        {
            fmr.ShowDialog();

            if (fmr.DialogResult == DialogResult.OK)
            {
                this.registro.ListaJugadores[indice] = fmr.Jugador;
                ado.ModificarFila(fmr.Jugador, this.nombreOriginal, this.apellidoOriginal);
                this.ActualizarRegistro();

            }
        }
        /// <summary>
        /// te muestra los datos del jugador de basket y te da la opurtunidad de cambiarles sus caracteristicas
        /// </summary>
        /// <param name="fmr">sera el formulario del jugador de basket</param>
        /// <param name="indice">el indice que va a localizar el jugador a eliminar</param>
        private void ModificarJugadorBasket(FmrBasket fmr, int indice)
        {
            fmr.ShowDialog();

            if (fmr.DialogResult == DialogResult.OK)
            {

                this.registro.ListaJugadores[indice] = fmr.Jugador;
                this.ado.ModificarFila(fmr.Jugador, this.nombreOriginal, this.apellidoOriginal);
                this.ActualizarRegistro();

            }
        }
        /// <summary>
        /// te muestra el form del jugador de beisbol y le modificas sus datos
        /// </summary>
        /// <param name="fmr">sera el formulario del jugador de beisbol</param>
        /// <param name="indice">identficara el jugador a eliminar</param>
        private void ModificarJugadorBeisbol(FmrBeisbol fmr, int indice)
        {
            fmr.ShowDialog();

            if (fmr.DialogResult == DialogResult.OK)
            {
                this.registro.ListaJugadores[indice] = fmr.jugador;
                this.ado.ModificarFila(fmr.jugador, nombreOriginal, apellidoOriginal);
                this.ActualizarRegistro();

            }
        }

        #region OPCION PARA CONFIRMAR SALIR DE LA APLICACION

        /// <summary>
        /// te da la opcion de confirmar de que quieras salir de la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FmrRegistro_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿estas seguro de salir de la aplicacion? ", "ATENCION", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rta == DialogResult.No)
            {
                e.Cancel = true;

            }
        }
        #endregion

        private void btbUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuariosLogeados fmrUsuario = new FormUsuariosLogeados();
            fmrUsuario.ShowDialog();

        }


    }
}
