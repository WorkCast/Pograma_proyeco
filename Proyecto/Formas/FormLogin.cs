using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FormLogin : Form
    {
        private Usuarios usuarios;
        public FormLogin()
        {
            InitializeComponent();
            usuarios = UsuariosData.ListaUsuarios; // Acceder a la lista de usuarios compartida
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*linkLabel1.LinkVisited = true;
                System.Diagnostics.Process.Start("")*/

            FormRegistro form = new FormRegistro();
            form.Show();
            
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormBackOfficeUsr form = new FormBackOfficeUsr();
            form.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string correo = textCorreo.Text;

            if (usuarios.BuscarPorCorr(correo))
            {
                Usuario u = usuarios.ObtenerPorCorr(correo);
                
                if(textContrasena.Text == u.contra)
                {

                    MessageBox.Show("Logeo exitoso!.", "Log in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UsuarioActual.usuario = u;
                    FormVerGrupo formVG = new FormVerGrupo();
                    formVG.Show();
                    
                    if (Convert.ToInt32(u.id)==0)
                    {
                        FormAdministracion formA = new FormAdministracion();
                        formA.Show();
                    }
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("Contrasena invalida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Correo no existente, haz click en el link para logearte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
