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
    public partial class FormUsuariosLogeados : Form
    {
        private List<string> usuarios;
        public FormUsuariosLogeados()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.usuarios = new List<string>();
            InitializeComponent();
            escribirUsuarios();
        }

        private void MostrarUsuarios()
        {
            try
            {
                using (StreamReader sr = File.OpenText("Usuarios.log"))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        this.usuarios.Add(linea);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hubo un error al leer el archivo de usuarios: " + ex.Message);
            }

            
        }

        private void escribirUsuarios()
        {
            
            MostrarUsuarios();

            foreach (string users in this.usuarios)
            {
                
                this.lstUsuarios.Items.Add(users);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
