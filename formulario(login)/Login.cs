using libreria_de_clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;

namespace formulario_login_
{
    public partial class Login : Form
    {

        List<Usuario> listaUsuarios = new List<Usuario>();
        public string nombreUsuario;
        public string apellido;
        public string perfil;
        private string correo;
        private string contraseña;
        private bool datosEncontrados;
        private int cantErrores;


        public int CantErrores
        {
            get { return this.cantErrores; }
            set { this.cantErrores += value; }
        }
        public Login()
        {
            this.listaUsuarios = new List<Usuario>();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Black;
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// se trae los datos del archivo json y si hay coincidencias con el usuario deja entrar a la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            this.correo = this.txtIniciarSesion.Text;
            this.contraseña = this.txtContraseña.Text;

            string nombreArchivo = "MOCK_DATA.json";

            Json<Usuario> json = new Json<Usuario>();
            this.listaUsuarios = json.Deserializar(nombreArchivo);

            if (this.VerificarDatos())
            {
                IniciarUsuario();
                FmrRegistro registro = new FmrRegistro(this);

                registro.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("VERIFICA TUS DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.CantErrores = 1;
            }

            if (this.CantErrores == 5)
            {
                MessageBox.Show("SUPERASTE LA CANTIDAD MAXIMA DE INTENTOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }
        /// <summary>
        /// verifica que los datos ingresados sean los mismos al de un usuario que este en el archivo
        /// </summary>
        /// <returns> retorna un booleano en el cual te dice si se encontro los datos o no</returns>
        private bool VerificarDatos()
        {
            this.datosEncontrados = false;

            for (int i = 0; i < this.listaUsuarios.Count; i++)
            {


                if (this.correo == this.listaUsuarios[i].correo && this.contraseña == this.listaUsuarios[i].clave)
                {
                    this.datosEncontrados = true;
                    this.nombreUsuario = listaUsuarios[i].nombre;
                    this.apellido = listaUsuarios[i].apellido;
                    this.perfil = listaUsuarios[i].perfil;
                    break;
                }
            }

            return this.datosEncontrados;
        }

        private void Login_Load(object sender, EventArgs e)
        {

            this.txtContraseña.UseSystemPasswordChar = true;
            this.lblOcultar.Visible = false;

        }

        private void lblMostrar_Click(object sender, EventArgs e)
        {
            this.txtContraseña.UseSystemPasswordChar = false;
            this.lblMostrar.Visible = false;
            this.lblOcultar.Visible = true;
        }

        private void lblOcultar_Click(object sender, EventArgs e)
        {
            this.txtContraseña.UseSystemPasswordChar = true;
            this.lblOcultar.Visible = false;
            this.lblMostrar.Visible = true;
        }

        private void IniciarUsuario()
        {
            try
            {
                using (StreamWriter sw = File.AppendText("Usuarios.log"))
                {
                    sw.WriteLine($"nombre: {this.nombreUsuario} - apellido: {this.apellido} - fecha de inicializacion: {DateTime.Now}");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("hubo un error con el archivo de los usuarios" + ex.Message);
            }
        }
    }


}
