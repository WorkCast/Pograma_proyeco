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
    public partial class FormPostear : Form
    {
        private Usuario usuario;
        private Posts posts;
        private Grupo grupo;
        private Grupos grupos;
        public FormPostear()
        {
            InitializeComponent();
            usuario = UsuarioActual.usuario;
            posts = PostData.ListaPosts;
            grupo = GrupoActual.grupo;
            grupos = GruposData.ListaGrupos;
        }

        private void Prueba_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            string content = textBox1.Text.Trim();

            if (content.Length > 10000)
            {
                MessageBox.Show("El post solo puede tener hasta 10000 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(content))
                {
                    Post post = new Post(posts.NuevoIdPost(), content,usuario.id);
                    if (cbxImagen.Checked)
                    {
                        //desactivar los checkBox
                        cbxImagen.Checked = false;
                        

                        // Si hay una imagen, agregarla al Panel
                        OpenFileDialog abrirImagen = new OpenFileDialog();
                        if (abrirImagen.ShowDialog() == DialogResult.OK)
                        {
                            post.tieneImagen = true;
                            post.dirImagen = abrirImagen.FileName;
                        }
                    }
                    UsuarioActual.usuario.postsDelUsr.AddPost(post);
                    grupo.postsGrupo.AddPost(post);
                    posts.AddPost(post);
                    //LoadPosts();

                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("El contenido del post no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnLlamarBackofice_Click(object sender, EventArgs e)
        {
            FormBackoffice formBackoff = new FormBackoffice();

            formBackoff.Show();
        }

        private void Prueba_Click_1(object sender, EventArgs e)
        {

        }
    }
}
