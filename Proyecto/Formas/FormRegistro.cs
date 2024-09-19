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
    public partial class FormRegistro : Form
    {
        Usuario u = new Usuario("0", "admin", "a", "admin@gmail.com", "12/12/1212", "AdM1N");
        
        private Usuarios usuarios;
        private Random rand;
        public FormRegistro()
        {
            InitializeComponent();
            usuarios = new Usuarios(); // Acceder a la lista de usuarios compartida
            usuarios.AgregarUsuario(u);
            UsuariosData.ListaUsuarios = usuarios;
            rand = new Random();
    }

        private void button1_Click(object sender, EventArgs e)
        {
            //int r = rand.Next(1, int.MaxValue);


            string id = Convert.ToString(usuarios.NuevoIdUser());
            string nom = textNombre.Text;
            string apell = textApellido.Text;
            string correo = textCorreo.Text;
            string fechaN = textFecha.Text;
            string contra = textContrasena.Text;
            
            if (nom != "" & apell != "" & correo != "" & fechaN != "" & contra != "")
            {
                if (/*ValidarEntradas()*/ usuarios.ValidarEntradas2(id,nom,apell,correo,fechaN,contra))
                {
                    Usuario u = new Usuario(id, nom, apell, correo, fechaN, contra);

                    usuarios.AgregarUsuario(u);
                    UsuarioActual.usuario = u;
                    FormIntereses formI = new FormIntereses();
                    formI.Show();
                    this.Hide();
                    //MessageBox.Show(usuarios.MostrarStringUsers()); linea de prueba
                    textNombre.Text="";
                    textApellido.Text="";
                    textCorreo.Text="";
                    textFecha.Text="";
                    textContrasena.Text = "";
                    textValidarCon.Text = "";

                    
                }
                else
                {
                    MessageBox.Show("Informacion incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                
            }
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin form = new FormLogin();
            form.Show();
            
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormBackOfficeUsr form = new FormBackOfficeUsr();
            form.Show();
        }

        /* private bool ValidarEntradas()
         {

         }*/
    }
}
