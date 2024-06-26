using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Proyecto
{
    public partial class FormBackoffice : Form
    {
        private Posts posts;
        private int selectedIndexPost = -1;
        private int selectedIndexCom = -1;
        private Timer timer;
        public FormBackoffice()
        {
            InitializeComponent();
            LoadPosts();
            posts = PostData.ListaPosts;
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
            if (selectedIndexCom == -1 && selectedIndexPost == -1)
            {
                // Código para actualizar el formulario
                LoadPosts();
            }
            
        }

        private void LoadPosts()
        {
            listBoxPosts.Items.Clear();
            listBoxComments.Items.Clear();
            foreach (Post post in Posts.GetPosts())
            {
                listBoxPosts.Items.Add(post.MostrarSoloPost());
            }
            labelId.Text = "Seleccione un post";
            textBoxPostText.Text = "";
            textBoxLikes.Text = "";
            textBoxComment.Text = "";
        }

        private void FormBackoffice_Load(object sender, EventArgs e)
        {

        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBoxPosts.SelectedItem != null)
            {
                
                selectedIndexPost = listBoxPosts.SelectedIndex;
                int postId = GetSelectedPostId();
                labelId.Text = postId.ToString();
                Post post = Posts.BuscarPostId(postId);
                textBoxPostText.Text = post.text;
                textBoxLikes.Text = post.likes.ToString();
                listBoxComments.Items.Clear();
                foreach (Comentario com in post.Comments)
                {
                    listBoxComments.Items.Add(com.Mostrar2());
                }   
            }
        }

        private int GetSelectedPostId()
        {
                        
                string selectedPost = listBoxPosts.SelectedItem.ToString();
                int colonIndex = selectedPost.IndexOf("-");
                return int.Parse(selectedPost.Substring(0, colonIndex));
                        
        }

        private int GetSelectedComentId()
        {

            string selectedComent = listBoxComments.SelectedItem.ToString();
            int colonIndex = selectedComent.IndexOf("-");
            return int.Parse(selectedComent.Substring(0, colonIndex));

        }

        private void listBoxComments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxComments.SelectedItem != null)
            {
                selectedIndexCom = listBoxPosts.SelectedIndex;
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDeletePost_Click(object sender, EventArgs e)
        {
            //validar si se selecciono algun post
            if (selectedIndexPost==-1)
            {
                MessageBox.Show("No ha selecionado un post.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int postId = GetSelectedPostId();
                Posts.DeletePost(postId);
                LoadPosts();
                selectedIndexPost = -1;
                
            }
            
        }

        private void buttonUpdateText_Click(object sender, EventArgs e)
        {
            if (selectedIndexPost == -1)
            {
                MessageBox.Show("No ha selecionado un post.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                if (textBoxPostText.Text.Trim()=="")
                {
                    MessageBox.Show("El campo de texto no puede ser espacio o vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int postId = GetSelectedPostId();
                    Posts.CambiarTextPost(postId, textBoxPostText.Text.Trim());
                    LoadPosts();
                    selectedIndexPost = -1;
                    
                }
                
            }
            
        }

        private void buttonAddComment_Click(object sender, EventArgs e)
        {
            if (selectedIndexPost == -1)
            {
                MessageBox.Show("No ha selecionado un post.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textBoxComment.Text.Trim() == "")
                {
                    MessageBox.Show("El campo de texto no puede ser espacio o vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Comentario com = new Comentario(posts.NuevoIdComentario(), textBoxComment.Text.Trim());
                    int postId = GetSelectedPostId();
                    Post post = Posts.BuscarPostId(postId);
                    post.AddComent(com);
                    LoadPosts();
                    selectedIndexPost = -1;
                    listBoxPosts.SelectedIndex = -1;
                    
                }
                
            }
            
        }

        private void buttonDeleteComment_Click(object sender, EventArgs e)
        {
            if (selectedIndexPost == -1 || selectedIndexCom == -1)
            {
                MessageBox.Show("No ha selecionado un post o comentario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int postId = GetSelectedPostId();
                int comId = GetSelectedComentId();
                //obtiene el usuario mediante su id para poder acceder a su lista de comentarios y borrarlo
                Posts.BuscarPostId(postId).BorrarComent(comId);
                //string comment = listBoxComments.SelectedItem.ToString();
                //Posts.RemoveCommentFromPost(postId, comment); aca
                LoadPosts();
                selectedIndexPost = -1;
                selectedIndexCom = -1;
            }
            
        }

        private void buttonUpdateLikes_Click(object sender, EventArgs e)
        {
            if (selectedIndexPost == -1)
            {
                MessageBox.Show("No ha selecionado un post.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int postId = GetSelectedPostId();
                int newLikes;
                if (int.TryParse(textBoxLikes.Text, out newLikes))
                {
                    Posts.UpdateLikes(postId, newLikes);
                    LoadPosts();
                }
                else
                {
                    MessageBox.Show("No es un numero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                selectedIndexPost = -1;
            }
            
        }

        private void btnAutoActualizar_Click(object sender, EventArgs e)
        {
            //Deseleccionamos para habilitar la actualizacion automatica
            listBoxPosts.SelectedIndex = -1;
            selectedIndexPost = -1;
            listBoxComments.SelectedIndex = -1;
            selectedIndexCom = -1;
        }
    }
}
