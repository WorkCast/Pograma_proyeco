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
    
    public partial class FormMuroGrupo : Form
    {
        private Usuarios usuarios;
        private Posts posts;
        private Grupo grupo;
        private Grupos grupos;
        public FormMuroGrupo()
        {
            InitializeComponent();
            usuarios = UsuariosData.ListaUsuarios;
            posts = PostData.ListaPosts;
            grupo = GrupoActual.grupo;
            grupos = GruposData.ListaGrupos;
            lblNombreG.Text = grupo.nombre;
            pictureBoxFoto.ImageLocation = grupo.dirImagen;
            LoadPosts();
            if (grupo.idCreador != Convert.ToInt32( UsuarioActual.usuario.id))
            {
                btnAdministrarGrup.Hide();
                btnCrearEvento.Hide();
            }
        }

        private void CrearEvento_Click(object sender, EventArgs e)
        {
            FormCrearEvento formCE = new FormCrearEvento();
            formCE.Show();
            
        }

        private void LoadPosts()
        {
            flpPosts.Controls.Clear();
            foreach (Post post in grupo.postsGrupo.posts)
            {

                AddPost(post);
            }
        }

        

        

        private void button1_Click(object sender, EventArgs e)
        {
            FormPostear formP = new FormPostear();
            formP.Show();
        }

        private void AddPost(Post nuevoPost)
        {
            // Crear un nuevo Panel para contener el post
            Panel postPanel = new Panel();

            postPanel.BackColor = Color.SeaShell;
            postPanel.BorderStyle = BorderStyle.FixedSingle;
            postPanel.Padding = new Padding(10);
            postPanel.Margin = new Padding(10);
            postPanel.AutoSize = true;
            postPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            postPanel.MaximumSize = new Size(flpPosts.ClientSize.Width - 20, 0); // Ajustar el ancho máximo
            postPanel.Width = flpPosts.ClientSize.Width - 20; // Establecer el ancho actual

            // Crear un FlowLayoutPanel para organizar los elementos dentro del postPanel
            FlowLayoutPanel flpPost = new FlowLayoutPanel();
            flpPost.FlowDirection = FlowDirection.TopDown;
            flpPost.WrapContents = false;
            flpPost.AutoSize = true;
            flpPost.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpPost.Width = postPanel.Width - 20;

            // Obtener el usuario que hizo el post
            Usuario usuarioPost = usuarios.ObtenerUsuarioId(nuevoPost.idUsr);

            // Crear un Label para mostrar el nombre del usuario que hizo el post
            Label userNameLabel = new Label();
            userNameLabel.Text = usuarioPost.nom + " " + usuarioPost.apell;
            userNameLabel.Font = new Font(userNameLabel.Font, FontStyle.Bold);
            userNameLabel.AutoSize = true;
            userNameLabel.MaximumSize = new Size(postPanel.Width - 20, 0);
            userNameLabel.Margin = new Padding(0, 0, 0, 10); // Margen inferior para separación

            // Agregar el Label del usuario al Panel
            flpPost.Controls.Add(userNameLabel);

            // Crear un Label para el contenido del post
            Label postLabel = new Label();
            postLabel.Text = nuevoPost.text;
            postLabel.AutoSize = true;
            postLabel.MaximumSize = new Size(postPanel.Width - 20, 0); // Ajustar el tamaño máximo del Label
            postLabel.Margin = new Padding(0, 0, 0, 10); // Margen inferior para separación

            // Agregar el Label del contenido del post al Panel
            flpPost.Controls.Add(postLabel);

            // Verificar si el post tiene imagen
            if (nuevoPost.tieneImagen)
            {
                // Crear un PictureBox para la imagen
                PictureBox contImagen = new PictureBox();
                contImagen.BorderStyle = BorderStyle.Fixed3D;
                contImagen.BackColor = Color.Silver;
                contImagen.ImageLocation = nuevoPost.dirImagen;
                contImagen.SizeMode = PictureBoxSizeMode.Zoom;
                contImagen.MaximumSize = new Size(postPanel.Width - 20, 200); // Ajustar tamaño máximo
                contImagen.MinimumSize = new Size(postPanel.Width - 20, 0); // Establecer tamaño mínimo
                contImagen.Width = postPanel.Width - 20; // Establecer el ancho actual del PictureBox
                contImagen.Height = 200; // Ajustar la altura fija del PictureBox

                // Agregar la imagen al Panel
                flpPost.Controls.Add(contImagen);
            }

            // Crear un panel para los controles de Like
            FlowLayoutPanel likePanel = new FlowLayoutPanel();
            likePanel.FlowDirection = FlowDirection.LeftToRight;
            likePanel.AutoSize = true;
            likePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            likePanel.Margin = new Padding(0, 10, 0, 0);

            // Crear un botón de Like
            Button likeButton = new Button();
            likeButton.Text = "Like";
            likeButton.AutoSize = true;
            likeButton.Width = 100;
            likeButton.Height = 30;
            likeButton.Margin = new Padding(0, 0, 10, 0);

            // Crear un Label para mostrar el número de Likes
            Label likesCountLabel = new Label();
            likesCountLabel.Text = nuevoPost.likes + " Likes";
            likesCountLabel.AutoSize = true;
            likesCountLabel.Margin = new Padding(0, 5, 0, 0);

            // Estado del Like y cantidad de Likes
            bool isLiked = false;

            // Evento de clic del botón de Like
            likeButton.Click += (s, e) =>
            {
                if (isLiked)
                {
                    isLiked = false;
                    nuevoPost.likes--;
                    likeButton.Text = "Like";
                }
                else
                {
                    isLiked = true;
                    nuevoPost.likes++;
                    likeButton.Text = "Dislike";
                }
                likesCountLabel.Text = $"{nuevoPost.likes} Likes";
            };

            // Crear un Label para la fecha actual
            Label fechaLabel = new Label();
            fechaLabel.Text = DateTime.Now.ToString("dd/MM/yyyy"); // Formato de fecha: día/mes/año
            fechaLabel.AutoSize = true;
            fechaLabel.Margin = new Padding(0, 5, 0, 0); // Margen superior para separación

            // Crear un Label para la hora actual
            Label horaLabel = new Label();
            horaLabel.Text = DateTime.Now.ToString("HH:mm"); // Formato de hora: horas:minutos
            horaLabel.AutoSize = true;
            horaLabel.Margin = new Padding(0, 5, 0, 0); // Margen superior para separación

            // Agregar el botón de Like, el Label de Likes, la fecha y la hora al likePanel
            likePanel.Controls.Add(likeButton);
            likePanel.Controls.Add(likesCountLabel);
            likePanel.Controls.Add(fechaLabel);
            likePanel.Controls.Add(horaLabel);

            // Agregar el likePanel al FlowLayoutPanel
            flpPost.Controls.Add(likePanel);

            // Sección de comentarios
            Panel commentPanelContainer = new Panel();
            commentPanelContainer.AutoSize = true;
            commentPanelContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            commentPanelContainer.Margin = new Padding(0, 20, 0, 0);

            FlowLayoutPanel flpCommentSection = new FlowLayoutPanel();
            flpCommentSection.FlowDirection = FlowDirection.TopDown;
            flpCommentSection.WrapContents = false;
            flpCommentSection.AutoSize = true;
            flpCommentSection.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpCommentSection.Margin = new Padding(0);

            // Cargar comentarios previos del post
            foreach (Comentario come in nuevoPost.listaComentarios.Comments)
            {
                // Crear un Panel para el comentario
                Panel comentPanel = new Panel();
                comentPanel.AutoSize = true;
                comentPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                comentPanel.BorderStyle = BorderStyle.FixedSingle;
                comentPanel.Margin = new Padding(0, 5, 0, 0);

                // Crear un Label para el comentario
                Label comentLabel = new Label();
                comentLabel.Text = come.texto;
                comentLabel.AutoSize = true;
                comentLabel.MaximumSize = new Size(postPanel.Width - 40, 0); // Ajustar tamaño máximo
                comentLabel.MinimumSize = new Size(postPanel.Width - 40, 0); // Ajustar tamaño mínimo
                comentLabel.Width = postPanel.Width - 40; // Establecer el ancho actual del Label
                comentLabel.Margin = new Padding(10);

                // Agregar el Label al Panel de comentario
                comentPanel.Controls.Add(comentLabel);

                // Agregar el Panel de comentario a la sección de comentarios
                flpCommentSection.Controls.Add(comentPanel);
            }

            // TextBox y Button para agregar nuevos comentarios
            FlowLayoutPanel commentInputPanel = new FlowLayoutPanel();
            commentInputPanel.FlowDirection = FlowDirection.LeftToRight;
            commentInputPanel.WrapContents = false;
            commentInputPanel.AutoSize = true;
            commentInputPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            commentInputPanel.Margin = new Padding(0, 0, 0, 10);

            TextBox textComentar = new TextBox();
            textComentar.Width = postPanel.Width - 100; // Ajustar el tamaño del TextBox
            textComentar.Margin = new Padding(0, 0, 10, 0);

            Button btnComentar = new Button();
            btnComentar.Text = "Enviar";
            btnComentar.AutoSize = true;
            btnComentar.Margin = new Padding(0);

            // Agregar TextBox y Button al panel de entrada de comentarios
            commentInputPanel.Controls.Add(textComentar);
            commentInputPanel.Controls.Add(btnComentar);

            // Evento Click del botón de comentar
            btnComentar.Click += (s, e) =>
            {
                string commentText = textComentar.Text;

                if (!string.IsNullOrWhiteSpace(commentText))
                {
                    // Crear el comentario y agregarlo al post
                    Comentario com = new Comentario(posts.NuevoIdComentario(), commentText);
                    nuevoPost.listaComentarios.AddComent(com);

                    Panel comentPanel = new Panel();
                    comentPanel.AutoSize = true;
                    comentPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                    comentPanel.BorderStyle = BorderStyle.FixedSingle;
                    comentPanel.Margin = new Padding(0, 5, 0, 0);

                    Label comentLabel = new Label();
                    comentLabel.Text = commentText;
                    comentLabel.AutoSize = true;
                    comentLabel.MaximumSize = new Size(postPanel.Width - 40, 0);
                    comentLabel.MinimumSize = new Size(postPanel.Width - 40, 0);

                    comentPanel.Controls.Add(comentLabel);

                    flpCommentSection.Controls.Add(comentPanel);

                    textComentar.Text = ""; // Limpiar el TextBox después de enviar el comentario
                }
            };

            // Agregar la sección de comentarios
            commentPanelContainer.Controls.Add(flpCommentSection);
            flpPost.Controls.Add(commentInputPanel);
            flpPost.Controls.Add(commentPanelContainer);

            // Finalmente, agregar el FlowLayoutPanel al Panel del post
            postPanel.Controls.Add(flpPost);

            // Agregar el Panel del post al FlowLayoutPanel de la interfaz
            flpPosts.Controls.Add(postPanel);
        }

        private void AddPost2(Post nuevoPost)
        {
            // Crear un nuevo Panel para contener el post
            Panel postPanel = new Panel();

            postPanel.BackColor = Color.SeaShell;
            postPanel.BorderStyle = BorderStyle.FixedSingle;
            postPanel.Padding = new Padding(10);
            postPanel.Margin = new Padding(10);
            postPanel.AutoSize = true;
            postPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            postPanel.MaximumSize = new Size(flpPosts.ClientSize.Width - 20, 0); // Ajustar el ancho máximo
            postPanel.Width = flpPosts.ClientSize.Width - 20; // Establecer el ancho actual

            // Crear un FlowLayoutPanel para organizar los elementos dentro del postPanel
            FlowLayoutPanel flpPost = new FlowLayoutPanel();
            flpPost.FlowDirection = FlowDirection.TopDown;
            flpPost.WrapContents = false;
            flpPost.AutoSize = true;
            flpPost.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpPost.Width = postPanel.Width - 20;

            // Obtener el usuario que hizo el post
            Usuario usuarioPost = usuarios.ObtenerUsuarioId(nuevoPost.idUsr);

            // Crear un Label para mostrar el nombre del usuario que hizo el post
            Label userNameLabel = new Label();
            
            userNameLabel.Text = usuarioPost.nom + " " + usuarioPost.apell;
            userNameLabel.Font = new Font(userNameLabel.Font, FontStyle.Bold);
            userNameLabel.AutoSize = true;
            userNameLabel.MaximumSize = new Size(postPanel.Width - 20, 0);
            userNameLabel.Margin = new Padding(0, 0, 0, 10); // Margen inferior para separación

            // Agregar el Label del usuario al Panel
            flpPost.Controls.Add(userNameLabel);

            // Crear un Label para el contenido del post
            Label postLabel = new Label();
            postLabel.Text = nuevoPost.text;
            postLabel.AutoSize = true;
            postLabel.MaximumSize = new Size(postPanel.Width - 20, 0); // Ajustar el tamaño máximo del Label
            postLabel.Margin = new Padding(0, 0, 0, 10); // Margen inferior para separación

            // Agregar el Label del contenido del post al Panel
            flpPost.Controls.Add(postLabel);

            if (nuevoPost.tieneImagen)
            {
                // Crear un PictureBox para la imagen
                PictureBox contImagen = new PictureBox();
                contImagen.BorderStyle = BorderStyle.Fixed3D;
                contImagen.BackColor = Color.Silver;
                contImagen.ImageLocation = nuevoPost.dirImagen;
                contImagen.SizeMode = PictureBoxSizeMode.Zoom;
                contImagen.MaximumSize = new Size(postPanel.Width - 20, 200); // Ajustar tamaño máximo
                contImagen.MinimumSize = new Size(postPanel.Width - 20, 0); // Establecer tamaño mínimo
                contImagen.Width = postPanel.Width - 20; // Establecer el ancho actual del PictureBox
                contImagen.Height = 200; // Ajustar la altura fija del PictureBox

                // Agregar la imagen al Panel
                flpPost.Controls.Add(contImagen);
            }

            // Crear un panel para los controles de Like
            FlowLayoutPanel likePanel = new FlowLayoutPanel();
            likePanel.FlowDirection = FlowDirection.LeftToRight;
            likePanel.AutoSize = true;
            likePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            likePanel.Margin = new Padding(0, 10, 0, 0);

            // Crear un botón de Like
            Button likeButton = new Button();
            likeButton.Text = "Like";
            likeButton.AutoSize = true;
            likeButton.Width = 100;
            likeButton.Height = 30;
            likeButton.Margin = new Padding(0, 0, 10, 0);

            // Crear un Label para mostrar el número de Likes
            Label likesCountLabel = new Label();
            likesCountLabel.Text = nuevoPost.likes + " Likes";
            likesCountLabel.AutoSize = true;
            likesCountLabel.Margin = new Padding(0, 5, 0, 0);

            // Estado del Like y cantidad de Likes
            bool isLiked = false;

            // Evento de clic del botón de Like
            likeButton.Click += (s, e) =>
            {
                if (isLiked)
                {
                    isLiked = false;
                    nuevoPost.likes--;
                    likeButton.Text = "Like";
                }
                else
                {
                    isLiked = true;
                    nuevoPost.likes++;
                    likeButton.Text = "Dislike";
                }
                likesCountLabel.Text = $"{nuevoPost.likes} Likes";
            };

            // Crear un Label para la fecha actual
            Label fechaLabel = new Label();
            fechaLabel.Text = DateTime.Now.ToString("dd/MM/yyyy"); // Formato de fecha: día/mes/año
            fechaLabel.AutoSize = true;
            fechaLabel.Margin = new Padding(0, 5, 0, 0); // Margen superior para separación

            // Crear un Label para la hora actual
            Label horaLabel = new Label();
            horaLabel.Text = DateTime.Now.ToString("HH:mm"); // Formato de hora: horas:minutos
            horaLabel.AutoSize = true;
            horaLabel.Margin = new Padding(0, 5, 0, 0); // Margen superior para separación

            // Agregar el botón de Like, el Label de Likes, la fecha y la hora al likePanel
            likePanel.Controls.Add(likeButton);
            likePanel.Controls.Add(likesCountLabel);
            likePanel.Controls.Add(fechaLabel);
            likePanel.Controls.Add(horaLabel);

            // Agregar el likePanel al FlowLayoutPanel
            flpPost.Controls.Add(likePanel);

            // Sección de comentarios
            Panel commentPanelContainer = new Panel();
            commentPanelContainer.AutoSize = true;
            commentPanelContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            commentPanelContainer.Margin = new Padding(0, 20, 0, 0);

            FlowLayoutPanel flpCommentSection = new FlowLayoutPanel();
            flpCommentSection.FlowDirection = FlowDirection.TopDown;
            flpCommentSection.WrapContents = false;
            flpCommentSection.AutoSize = true;
            flpCommentSection.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpCommentSection.Margin = new Padding(0);

            // TextBox y Button para agregar comentarios
            FlowLayoutPanel commentInputPanel = new FlowLayoutPanel();
            commentInputPanel.FlowDirection = FlowDirection.LeftToRight;
            commentInputPanel.WrapContents = false;
            commentInputPanel.AutoSize = true;
            commentInputPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            commentInputPanel.Margin = new Padding(0, 0, 0, 10);

            TextBox textComentar = new TextBox();
            textComentar.Width = postPanel.Width - 100; // Ajustar el tamaño del TextBox
            textComentar.Margin = new Padding(0, 0, 10, 0);

            Button btnComentar = new Button();
            btnComentar.Text = "Enviar";
            btnComentar.AutoSize = true;
            btnComentar.Margin = new Padding(0);

            // Agregar TextBox y Button al panel de entrada de comentarios
            commentInputPanel.Controls.Add(textComentar);
            commentInputPanel.Controls.Add(btnComentar);

            // Evento Click del botón de comentar
            btnComentar.Click += (s, e) =>
            {
                string commentText = textComentar.Text;

                if (!string.IsNullOrWhiteSpace(commentText))
                {
                    // Crear el comentario y agregarlo al post
                    Comentario com = new Comentario(posts.NuevoIdComentario(), commentText);
                    nuevoPost.listaComentarios.AddComent(com);

                    Panel comentPanel = new Panel();
                    comentPanel.AutoSize = true;
                    comentPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                    comentPanel.BorderStyle = BorderStyle.FixedSingle;
                    comentPanel.Margin = new Padding(0, 5, 0, 0);

                    Label comentLabel = new Label();
                    comentLabel.Text = commentText;
                    comentLabel.AutoSize = true;
                    comentLabel.MaximumSize = new Size(postPanel.Width - 40, 0);
                    comentLabel.MinimumSize = new Size(postPanel.Width - 40, 0);

                    comentPanel.Controls.Add(comentLabel);

                    flpCommentSection.Controls.Add(comentPanel);

                    textComentar.Text = ""; // Limpiar el TextBox después de enviar el comentario
                }
            };

            // Agregar la sección de comentarios
            commentPanelContainer.Controls.Add(flpCommentSection);
            flpPost.Controls.Add(commentInputPanel);
            flpPost.Controls.Add(commentPanelContainer);

            // Finalmente, agregar el FlowLayoutPanel al Panel del post
            postPanel.Controls.Add(flpPost);

            // Agregar el Panel del post al FlowLayoutPanel de la interfaz
            flpPosts.Controls.Add(postPanel);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LoadPosts();
        }

        private void FormMuroGrupo_Load(object sender, EventArgs e)
        {

        }

        private void btnVerEventosG_Click(object sender, EventArgs e)
        {
            FormVerEventos formVE = new FormVerEventos();
            formVE.Show();
            
        }

        private void btnEtiquetas_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GrupoActual.grupo.intereses.MostrarIntereces());
        }

        private void btnAdministrarGrup_Click(object sender, EventArgs e)
        {

        }
    }
}
