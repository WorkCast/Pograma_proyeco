using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto
{
    public partial class FormBackOfficeUsr : Form
    {
       // private Usuarios usuarios = new Usuarios();
        private int selectedIndex = -1;
        private bool clikMod = false;
        private Usuarios usuarios;
        Grupos grupos;
        private Timer timer;
        public FormBackOfficeUsr()
        {
            InitializeComponent();
            usuarios = UsuariosData.ListaUsuarios; // Acceder a la lista de usuarios compartida
            grupos = GruposData.ListaGrupos;
            InicializarTimer();
        }

        private void InicializarTimer()
        {
            // Crear una instancia del Timer
            timer = new Timer();

            // Establecer el intervalo a 1000 milisegundos (1 segundo)
            timer.Interval = 1000;

            // Asignar el evento Tick al método Timer_Tick
            timer.Tick += new EventHandler(Timer_Tick);

            // Iniciar el Timer
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //actualizar solo si no hay nada seleccionado para modificar
            if (selectedIndex == -1 )
            {
                // Código para actualizar el formulario
                LoadUser();
            }

        }

        private void LoadUser()
        {
            
            listUsuarios.Items.Clear();

            foreach (Usuario u in usuarios.GetUsuarios())
            {
                listUsuarios.Items.Add(u.MostrarU());
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            selectedIndex = -1;
            listUsuarios.SelectedIndex = -1;
            string id = Convert.ToString(usuarios.NuevoIdUser());
            string nom = textNombre.Text;
            string apell = textApellido.Text;
            string correo = textCorreo.Text;
            string fechaN = textFecha.Text;
            string contra = textContrasena.Text;
            if (nom != "" & apell != "" & correo != "" & fechaN != "" & contra != "")
            {
                if (usuarios.ValidarEntradas(id, nom, apell, correo, fechaN, contra, selectedIndex, clikMod))
                {
                    Usuario u = new Usuario(id, nom, apell, correo, fechaN,contra);

                    usuarios.AgregarUsuario(u);
                    listUsuarios.Items.Add(u.MostrarU());
                    textID.Clear();
                    textNombre.Clear();
                    textApellido.Clear();
                    textCorreo.Clear();
                    textFecha.Clear();
                    textContrasena.Clear();
                }
                else
                {
                    MessageBox.Show("Hay datos incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hay datos faltantes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("el orden en el que se ve la informacion es el mismo que el de ingreso de datos, para eliminar debe hacer clic al usuario en la lista, cambiar datos de un usuario no cambia su id.", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void listUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listUsuarios.SelectedItem != null)
            {
                selectedIndex = listUsuarios.SelectedIndex;

                textID.Text = usuarios.ObtenerUsuarioId(Convert.ToString( GetSelectedUserId())).id;
                textNombre.Text = usuarios.ObtenerUsuarioId(Convert.ToString(GetSelectedUserId())).nom;
                textApellido.Text = usuarios.ObtenerUsuarioId(Convert.ToString(GetSelectedUserId())).apell;
                textCorreo.Text = usuarios.ObtenerUsuarioId(Convert.ToString(GetSelectedUserId())).correo;
                textFecha.Text = usuarios.ObtenerUsuarioId(Convert.ToString(GetSelectedUserId())).fechaN;
                textContrasena.Text = usuarios.ObtenerUsuarioId(Convert.ToString(GetSelectedUserId())).contra;
                LoadPosts();
            }
        }
        private int GetSelectedUserId()
        {
            if (listUsuarios.SelectedItem != null)
            {
                string selectedPost = listUsuarios.SelectedItem.ToString();
                int colonIndex = selectedPost.IndexOf("-");
                //MessageBox.Show(Convert.ToString(selectedPost.Substring(0, colonIndex)));
                return int.Parse(selectedPost.Substring(0, colonIndex));
            }
            return 0;
        }
        private void LoadPosts()
        {
            listBoxPosts.Items.Clear();
            
            foreach (Post post in usuarios.ObtenerUsuarioId(Convert.ToString(GetSelectedUserId())).postsDelUsr.posts)
            {
                listBoxPosts.Items.Add(post.MostrarSoloPost());
            }

        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (selectedIndex >= 0 && selectedIndex < listUsuarios.Items.Count)
            {
                usuarios.ObtenerUsuarioId(Convert.ToString( GetSelectedUserId())).postsDelUsr.posts.RemoveRange(0, usuarios.ObtenerUsuarioId(Convert.ToString(GetSelectedUserId())).postsDelUsr.posts.Count);
                foreach (Grupo grupo in grupos.grupos)
                {
                    if (grupo.usuarios.ExisteUser(GetSelectedUserId()))
                    {
                        grupo.usuarios.EliminarUsuario(GetSelectedUserId());
                    }
                }
                
                

                usuarios.EliminarUsuario(selectedIndex);
                listUsuarios.Items.RemoveAt(selectedIndex);                
                selectedIndex = -1;
                listUsuarios.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Primero selecione un usuario a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        





        private void textCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        /// /////////////////////////////////////////////////////////
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedIndex >= 0 && selectedIndex < listUsuarios.Items.Count)
            {
                clikMod = true;
                Usuario userMod = usuarios.ObtenerUsuario(selectedIndex);
                if (usuarios.ValidarEntradas(textID.Text, textNombre.Text, textApellido.Text, textCorreo.Text, textFecha.Text, textContrasena.Text, selectedIndex, clikMod))
                {
                    

                    

                    //userMod.id = textID.Text;
                    userMod.nom = textNombre.Text;
                    userMod.apell = textApellido.Text;
                    userMod.correo = textCorreo.Text;
                    userMod.fechaN = textFecha.Text;
                    userMod.contra = textContrasena.Text;



                    ///////////
                    usuarios.EliminarUsuario(selectedIndex);
                    listUsuarios.Items.RemoveAt(selectedIndex);
                    ///////////
                    ///
                    usuarios.AgregarUsuario(userMod);
                    listUsuarios.Items.Add(userMod.MostrarU());
                    /*
                    // Actualizar el ArrayList de usuarios
                    usuarios.ActualizarUsuario(selectedIndex, userMod);

                    // Actualizar el ListBox
                    listUsuarios.Items[selectedIndex] = userMod.MostrarU();
                    */
                    // Limpiar los TextBoxes después de modificar

                    textID.Clear();
                    textNombre.Clear();
                    textApellido.Clear();
                    textCorreo.Clear();
                    textFecha.Clear();
                    textContrasena.Clear();

                    // Reiniciar el índice seleccionado
                    selectedIndex = -1;
                    listUsuarios.SelectedIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("Primero selecione un usuario a modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clikMod = false;
        }

        private void btnCargarPrueba_Click(object sender, EventArgs e)
        {
            
            Usuario u = new Usuario("2", "maolo", "pereira", "manoPer@gmail.com", "12/12/2000", "password1");
            Usuario u1 = new Usuario("3", "Carlos", "Gómez", "carlosgomez@gmail.com", "10/05/1995", "password123");
            Usuario u2 = new Usuario("4", "Matu", "Pereira", "matuPer@gmail.com", "03/04/2000", "pa55w0rdSegura");
            Usuario u3 = new Usuario("5", "Laura", "Fernández", "laurafernandez@yahoo.com", "25/08/1998", "mysecurepass");
            usuarios.AgregarUsuario(u);
            usuarios.AgregarUsuario(u1);
            usuarios.AgregarUsuario(u2);
            usuarios.AgregarUsuario(u3);
            LoadUser();
            btnCargarPrueba.Enabled = false;
            //listUsuarios.Items.Add(u.MostrarU());
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            selectedIndex = -1;
            listUsuarios.SelectedIndex = -1;
        }

        private void FormBackOfficeUsr_Load(object sender, EventArgs e)
        {

        }
    }
}
