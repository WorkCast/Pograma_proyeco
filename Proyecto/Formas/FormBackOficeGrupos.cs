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
    public partial class FormBackOficeGrupos : Form
    {
        private Etiquetas etiquetas;
        private Grupos grupos;
        private Posts posts;
        private Eventos eventos;
        private Usuarios usuarios;
        private Timer timer;
        Intereses intereses;
        int idEti1 = 0;
        int idEti2 = 0;
        int idEti3 = 0;
        string dirImg="";
        int selectedGru = -1;
        int selectedIndexPost = -1;
        int selectedIndex = -1;
        int selectedEve = -1;
        int idEve=0;
        int idPost = 0;
        int idUsr = 0;
        public FormBackOficeGrupos()
        {
            InitializeComponent();
            etiquetas = new Etiquetas();
            etiquetas.CargarEtiquetas();
            EtiquetasData.etiquetasData = etiquetas;
            grupos = GruposData.ListaGrupos;
            posts = PostData.ListaPosts;
            eventos = EventosData.listaEventos;
            usuarios = UsuariosData.ListaUsuarios;
            intereses = new Intereses();
            InicializarTimer();

        }

        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();
            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {

                dirImg = abrirImagen.FileName;
                pictureBoxFoto.ImageLocation = dirImg;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void lugaresCerradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idEti1 = 1;
            Convert.ToString(idEti1);
            txtEti1.Text = etiquetas.BuscarPorId(Convert.ToString(idEti1)).nombre;
        }

        public Intereses DevolverIntereses()
        {

            Intereses inte = new Intereses();

            if (idEti1 != 0)
            {
                inte.etiqueta1 = etiquetas.BuscarPorId(Convert.ToString(idEti1));
            }
            else
            {
                inte.etiqueta1 = null;
            }
            if (idEti2 != 0)
            {
                inte.etiqueta2 = etiquetas.BuscarPorId(Convert.ToString(idEti2));
            }
            else
            {
                inte.etiqueta2 = null;
            }
            if (idEti3 != 0)
            {
                inte.etiqueta3 = etiquetas.BuscarPorId(Convert.ToString(idEti3));
            }
            else
            {
                inte.etiqueta3 = null;
            }
            //MessageBox.Show(inte.MostrarIntereces());
            return inte;
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
            //lblP.Text = Convert.ToString(selectedEve);
            if (selectedGru == -1)
            {
                // Código para actualizar el formulario
                LoadGrupos();
            }

        }

        

        private void lugaresAviertosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idEti1 = 2;
            txtEti1.Text = etiquetas.BuscarPorId(Convert.ToString(idEti1)).nombre;
        }

        private void cerrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idEti1 = 3;
            txtEti1.Text = etiquetas.BuscarPorId(Convert.ToString(idEti1)).nombre;
        }

        private void patrimonioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idEti1 = 4;
            txtEti1.Text = etiquetas.BuscarPorId(Convert.ToString(idEti1)).nombre;
        }

        private void parquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idEti1 = 5;
            txtEti1.Text = etiquetas.BuscarPorId(Convert.ToString(idEti1)).nombre;
        }

        private void playasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idEti1 = 6;
            txtEti1.Text = etiquetas.BuscarPorId(Convert.ToString(idEti1)).nombre;
        }

        private void campingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idEti1 = 7;
            txtEti1.Text = etiquetas.BuscarPorId(Convert.ToString(idEti1)).nombre;
        }

        private void teatrosCinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idEti1 = 8;
            txtEti1.Text = etiquetas.BuscarPorId(Convert.ToString(idEti1)).nombre;
        }

        private void estanciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idEti1 = 9;
            txtEti1.Text = etiquetas.BuscarPorId(Convert.ToString(idEti1)).nombre;
        }

        private void restaurantesbaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idEti1 = 10;
            txtEti1.Text = etiquetas.BuscarPorId(Convert.ToString(idEti1)).nombre;
        }

        private void zoologicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idEti1 = 11;
            txtEti1.Text = etiquetas.BuscarPorId(Convert.ToString(idEti1)).nombre;
        }

        private void mercadosferiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idEti1 = 12;
            txtEti1.Text = etiquetas.BuscarPorId(Convert.ToString(idEti1)).nombre;
        }

        private void shoppingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idEti1 = 13;
            txtEti1.Text = etiquetas.BuscarPorId(Convert.ToString(idEti1)).nombre;
        }

        private void museosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idEti1 = 14;
            txtEti1.Text = etiquetas.BuscarPorId(Convert.ToString(idEti1)).nombre;
        }

        private void monumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idEti1 = 15;
            txtEti1.Text = etiquetas.BuscarPorId(Convert.ToString(idEti1)).nombre;
        }

        private void parroquiasIglesiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idEti1 = 16;
            txtEti1.Text = etiquetas.BuscarPorId(Convert.ToString(idEti1)).nombre;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            idEti2 = 1;
            txtEti2.Text = etiquetas.BuscarPorId(Convert.ToString(idEti2)).nombre;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            idEti2 = 2;
            txtEti2.Text = etiquetas.BuscarPorId(Convert.ToString(idEti2)).nombre;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            idEti2 = 3;
            txtEti2.Text = etiquetas.BuscarPorId(Convert.ToString(idEti2)).nombre;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            idEti2 = 4;
            txtEti2.Text = etiquetas.BuscarPorId(Convert.ToString(idEti2)).nombre;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            idEti2 = 5;
            txtEti2.Text = etiquetas.BuscarPorId(Convert.ToString(idEti2)).nombre;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            idEti2 = 6;
            txtEti2.Text = etiquetas.BuscarPorId(Convert.ToString(idEti2)).nombre;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            idEti2 = 7;
            txtEti2.Text = etiquetas.BuscarPorId(Convert.ToString(idEti2)).nombre;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            idEti2 = 8;
            txtEti2.Text = etiquetas.BuscarPorId(Convert.ToString(idEti2)).nombre;
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            idEti2 = 9;
            txtEti2.Text = etiquetas.BuscarPorId(Convert.ToString(idEti2)).nombre;
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            idEti2 = 10;
            txtEti2.Text = etiquetas.BuscarPorId(Convert.ToString(idEti2)).nombre;
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            idEti2 = 11;
            txtEti2.Text = etiquetas.BuscarPorId(Convert.ToString(idEti2)).nombre;
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            idEti2 = 12;
            txtEti2.Text = etiquetas.BuscarPorId(Convert.ToString(idEti2)).nombre;
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            idEti2 = 13;
            txtEti2.Text = etiquetas.BuscarPorId(Convert.ToString(idEti2)).nombre;
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            idEti2 = 14;
            txtEti2.Text = etiquetas.BuscarPorId(Convert.ToString(idEti2)).nombre;
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            idEti2 = 15;
            txtEti2.Text = etiquetas.BuscarPorId(Convert.ToString(idEti2)).nombre;
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            idEti2 = 16;
            txtEti2.Text = etiquetas.BuscarPorId(Convert.ToString(idEti2)).nombre;
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            idEti3 = 1;
            txtEti3.Text = etiquetas.BuscarPorId(Convert.ToString(idEti3)).nombre;
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            idEti3 = 2;
            txtEti3.Text = etiquetas.BuscarPorId(Convert.ToString(idEti3)).nombre;
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            idEti3 = 3;
            txtEti3.Text = etiquetas.BuscarPorId(Convert.ToString(idEti3)).nombre;
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            idEti3 = 4;
            txtEti3.Text = etiquetas.BuscarPorId(Convert.ToString(idEti3)).nombre;
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            idEti3 = 5;
            txtEti3.Text = etiquetas.BuscarPorId(Convert.ToString(idEti3)).nombre;
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            idEti3 = 6;
            txtEti3.Text = etiquetas.BuscarPorId(Convert.ToString(idEti3)).nombre;
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            idEti3 = 7;
            txtEti3.Text = etiquetas.BuscarPorId(Convert.ToString(idEti3)).nombre;
        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {
            idEti3 = 8;
            txtEti3.Text = etiquetas.BuscarPorId(Convert.ToString(idEti3)).nombre;
        }

        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {
            idEti3 = 9;
            txtEti3.Text = etiquetas.BuscarPorId(Convert.ToString(idEti3)).nombre;
        }

        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        {
            idEti3 = 10;
            txtEti3.Text = etiquetas.BuscarPorId(Convert.ToString(idEti3)).nombre;
        }

        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        {
            idEti3 = 11;
            txtEti3.Text = etiquetas.BuscarPorId(Convert.ToString(idEti3)).nombre;
        }

        private void toolStripMenuItem28_Click(object sender, EventArgs e)
        {
            idEti3 = 12;
            txtEti3.Text = etiquetas.BuscarPorId(Convert.ToString(idEti3)).nombre;
        }

        private void toolStripMenuItem29_Click(object sender, EventArgs e)
        {
            idEti3 = 13;
            txtEti3.Text = etiquetas.BuscarPorId(Convert.ToString(idEti3)).nombre;
        }

        private void toolStripMenuItem30_Click(object sender, EventArgs e)
        {
            idEti3 = 14;
            txtEti3.Text = etiquetas.BuscarPorId(Convert.ToString(idEti3)).nombre;
        }

        private void toolStripMenuItem31_Click(object sender, EventArgs e)
        {
            idEti3 = 15;
            txtEti3.Text = etiquetas.BuscarPorId(Convert.ToString(idEti3)).nombre;
        }

        private void toolStripMenuItem32_Click(object sender, EventArgs e)
        {
            idEti3 = 16;
            txtEti3.Text = etiquetas.BuscarPorId(Convert.ToString(idEti3)).nombre;
        }

        private void FormBackOficeGrupos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("haga click derecho sobre los capos de texto de las etiquetas para elegir lo que desee. Cambiar el texto no hara que cambie la opcion elegida");
        }

        private void LoadGrupos()
        {
            listGrupos.Items.Clear();

            foreach (Grupo gru in grupos.grupos)
            {
                listGrupos.Items.Add(gru.MostrarGrupo());
            }

        }
        private int GetSelectedGruId()
        {

            if (listGrupos.SelectedItem != null)
            {
                string selectedEve = listGrupos.SelectedItem.ToString();
                int colonIndex = selectedEve.IndexOf(" - ");
                return int.Parse(selectedEve.Substring(0, colonIndex));
            }

            return 0;
        }

        private void listGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listGrupos.SelectedItem != null)
            {
                Convert.ToString(GetSelectedGruId());
                Convert.ToInt32(GetSelectedGruId());
                selectedGru = listGrupos.SelectedIndex;
                lblId.Text = Convert.ToString(grupos.ObtenerPorId(Convert.ToInt32(GetSelectedGruId())).id);
                lblIdCreador.Text = Convert.ToString(grupos.ObtenerPorId(Convert.ToInt32(GetSelectedGruId())).idCreador);
                txtNombre.Text = grupos.ObtenerPorId(Convert.ToInt32(GetSelectedGruId())).nombre;
                txtDescripcion.Text = grupos.ObtenerPorId(Convert.ToInt32(GetSelectedGruId())).descripcion;
                pictureBoxFoto.ImageLocation = grupos.ObtenerPorId(Convert.ToInt32(GetSelectedGruId())).dirImagen;
                LoadUsuariosGrupo();
                LoadPostsGrupo();
                LoadEventos();
            }
        }
        private void LoadUsuariosGrupo()
        {
            listUsuarios.Items.Clear();
            //Usuarios u = grupos.ObtenerPorId(Convert.ToInt32(GetSelectedGruId())).usuarios;

            foreach (Usuario us in grupos.ObtenerPorId(Convert.ToInt32(GetSelectedGruId())).usuarios.listaUsuarios)
            {
                listUsuarios.Items.Add(us.MostrarU());
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
        private void listUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listUsuarios.SelectedItem != null)
            {
                selectedIndex = listUsuarios.SelectedIndex;

            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (selectedIndex ==-1|| GetSelectedUserId() == grupos.ObtenerPorId(GetSelectedGruId()).idCreador)
            {
                
                MessageBox.Show("Primero selecione un usuario a eliminar. tambien puede ser que este queriendo eliminar al dueño del grupo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //usuarios.EliminarUsrID(GetSelectedUserId());
               
                grupos.ObtenerPorId(Convert.ToInt32(GetSelectedGruId())).usuarios.EliminarUsrID(GetSelectedUserId());
                

                //UsuariosData.ListaUsuarios = usuarios;
                //listUsuarios.Items.RemoveAt(selectedIndex);
                LoadUsuariosGrupo();
                selectedIndex = -1;
                listUsuarios.SelectedIndex = -1;
            }
        }
        private void LoadPostsGrupo()
        {
            listBoxPosts.Items.Clear();

            foreach (Post post in grupos.ObtenerPorId(Convert.ToInt32(GetSelectedGruId())).postsGrupo.posts)
            {
                listBoxPosts.Items.Add(post.MostrarSoloPost());
            }

        }
        private int GetSelectedPostId()
        {
            string selectedPost = listBoxPosts.SelectedItem.ToString();
            int colonIndex = selectedPost.IndexOf("-");
            return int.Parse(selectedPost.Substring(0, colonIndex));
        }
        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPosts.SelectedItem != null)
            {

                selectedIndexPost = listBoxPosts.SelectedIndex;
            }
        }
        private void btnEliminarPost_Click(object sender, EventArgs e)
        {
            if (selectedIndexPost == -1)
            {
                MessageBox.Show("No ha selecionado un post.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                int postId = GetSelectedPostId();
                foreach (Usuario us in grupos.ObtenerPorId(Convert.ToInt32(GetSelectedGruId())).usuarios.listaUsuarios)
                {
                    if (us.postsDelUsr.ExistePost(GetSelectedPostId()))
                    {
                        us.postsDelUsr.DeletePost(postId);
                    }
                }
                
                grupos.ObtenerPorId(Convert.ToInt32(GetSelectedGruId())).postsGrupo.DeletePost(postId);
                posts.DeletePost(postId);
                PostData.ListaPosts = posts;
                LoadPostsGrupo();
                selectedIndexPost = -1;

            }
        }
        private void LoadEventos()
        {
            listEventos.Items.Clear();

            foreach (Evento eve in grupos.ObtenerPorId(Convert.ToInt32(GetSelectedGruId())).eventosGrupo.listaEventos)
            {
                listEventos.Items.Add(eve.MostrarEvento());
            }

        }
        private int GetSelectedEveId()
        {

            if (listEventos.SelectedItem != null)
            {
                string selectedEve = listEventos.SelectedItem.ToString();
                int colonIndex = selectedEve.IndexOf(" - ");
                return int.Parse(selectedEve.Substring(0, colonIndex));
            }

            return 0;
        }

        private void listEventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listEventos.SelectedItem != null)
            {
                selectedEve = listEventos.SelectedIndex;
                
            }
        }
            private void btnEliminarEvento_Click(object sender, EventArgs e)
        {
            if (selectedEve == -1)
            {
                MessageBox.Show("no seleciono ningun evento");
            }
            else
            {

                grupos.ObtenerPorId(Convert.ToInt32(GetSelectedGruId())).eventosGrupo.EliminarEvento(GetSelectedEveId());
                eventos.EliminarEvento(GetSelectedEveId());
                EventosData.listaEventos = eventos;
                selectedEve = -1;
                listEventos.SelectedIndex = -1;
                LoadEventos();
            }
        }
        
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            listGrupos.SelectedItem = -1;
            listBoxPosts.SelectedItem = -1;
            listEventos.SelectedItem = -1;
            listUsuarios.SelectedItem = -1;
            selectedGru = -1;
            selectedIndexPost = -1;
            selectedIndex = -1;
            selectedEve = -1;
            listBoxPosts.Items.Clear();
            listEventos.Items.Clear();
            listUsuarios.Items.Clear();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedGru==-1)
            {
                MessageBox.Show("no seleciono ningun evento");
            }
            else
            {
                //primero eliminamos los eventos del grupo y fuera de el
                grupos.ObtenerPorId(GetSelectedGruId());
                foreach (Evento ev in grupos.ObtenerPorId(GetSelectedGruId()).eventosGrupo.listaEventos)
                {
                    if (eventos.ExisteEvento(ev.idEvento))
                    {
                        eventos.EliminarEvento(ev.idEvento);
                    }
                    
                }

                EventosData.listaEventos = eventos;
                //eliminamos los post dentro del grupo y fuera de el
                foreach (Post p in grupos.ObtenerPorId(GetSelectedGruId()).postsGrupo.posts)
                {
                    if (posts.ExistePost(p.id))
                    {
                        posts.DeletePost(p.id);
                    }
                    
                }
                PostData.ListaPosts = posts;
                grupos.EliminarGrupo(GetSelectedGruId());
                GruposData.ListaGrupos = grupos;
                LoadGrupos();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((idEti1==0&& idEti2 == 0&& idEti3 == 0) || txtDescripcion.Text == "" || txtNombre.Text == "" || dirImg == "")
            {
                MessageBox.Show("datos faltantes");
            }
            else
            {
                string desc = txtDescripcion.Text;
                string nom = txtNombre.Text;
                

                intereses = DevolverIntereses();
                //MessageBox.Show(intereses.MostrarIntereces());
                Grupo g = new Grupo(grupos.NuevoIdGrupo(), Convert.ToInt32(UsuarioActual.usuario.id), nom, desc);
                g.intereses = intereses;
                g.dirImagen = dirImg;
                g.usuarios.AgregarUsuario(UsuarioActual.usuario);
                g.idCreador =Convert.ToInt32( UsuarioActual.usuario.id);
                //MessageBox.Show(g.MostrarGrupo());

                grupos.AgregarGrupo(g);
                GruposData.ListaGrupos = grupos;
                MessageBox.Show("Bien! Cresacion de grupo completa ");
                idEti1 = 0;
                txtEti1.Text = "";
                idEti2 = 0;
                txtEti2.Text = "";
                idEti3 = 0;
                txtEti3.Text = "";
                dirImg = "";
                LoadGrupos();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((idEti1 == 0 && idEti2 == 0 && idEti3 == 0) || txtDescripcion.Text == "" || txtNombre.Text == "" || dirImg == "")
            {
                MessageBox.Show("datos faltantes");
            }
            else
            {
                string desc = txtDescripcion.Text;
                string nom = txtNombre.Text;


                intereses = DevolverIntereses();
                grupos.ModificarGrupo(GetSelectedGruId(),nom,desc,dirImg,intereses);
                
                GruposData.ListaGrupos = grupos;
                MessageBox.Show("Grupo modificado correctamente");
                idEti1 = 0;
                txtEti1.Text = "";
                idEti2 = 0;
                txtEti2.Text = "";
                idEti3 = 0;
                txtEti3.Text = "";
                dirImg = "";
                LoadGrupos();
            }
        }
    }
}
