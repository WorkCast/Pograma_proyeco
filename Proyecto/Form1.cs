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
    public partial class Form1 : Form
    {
        public Form1()
        {


            InitializeComponent();
            flowLayoutPanel2.SizeChanged += AjustarTextBOX;
            //flowLayoutPanel2.WrapContents = false;
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // Configurar el TextBox inicialmente
            AjustarTextBOX(this, EventArgs.Empty);

            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
            //flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.AutoScroll = false;

            // Configurar el Panel contenedor para que tenga barras de desplazamiento automáticas
            panel1.AutoScroll = true;
            panel1.Dock = DockStyle.Fill;

            flowLayoutPanel1.SizeChanged += (s, e) => {
                
                AdjustPanelSizes();
            };

            panel1.AutoScroll = true;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string content = textBox1.Text.Trim();

            if (content.Length>10000)
            {
                MessageBox.Show("El post solo puede tener hasta 10000 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(content))
                            {
                                AddPost(content);
                                textBox1.Clear();
                            }
                            else
                            {
                                MessageBox.Show("El contenido del post no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
            }

        private void AjustarProporcionesPictureBox(PictureBox pictureBox, int newWidth)
        {
            if (pictureBox.Image != null)
            {
                // Calcula el nuevo alto manteniendo la proporción de la imagen
                int originalWidth = pictureBox.Image.Width;
                int originalHeight = pictureBox.Image.Height;
                int newHeight = (int)((float)originalHeight / originalWidth * newWidth);

                // Establece el nuevo tamaño del PictureBox
                pictureBox.Size = new Size(newWidth, newHeight);
            }
        }

        private void AdjustPanelSizes()
        {
            
            
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Panel postPanel)
                {
                    int panelWidth = flowLayoutPanel1.ClientSize.Width - 20;
                    postPanel.MaximumSize = new Size(panelWidth, 0);
                    postPanel.MinimumSize = new Size(panelWidth, 0);
                    postPanel.Width = panelWidth;

                    foreach (Control subPanel in postPanel.Controls)
                    {
                        if (subPanel is Panel labelPanel || subPanel is Panel imagePanel)
                        {
                            subPanel.Width = panelWidth - 20;

                            foreach (Control child in subPanel.Controls)
                            {
                                if (child is Label postLabel)
                                {
                                    postLabel.MaximumSize = new Size(panelWidth - 20, 0);
                                    postLabel.MinimumSize = new Size(panelWidth - 20, 0);
                                    postLabel.Width = panelWidth - 20;
                                }
                                else if (child is PictureBox contImagen)
                                {
                                    contImagen.MaximumSize = new Size(panelWidth - 20, 200);
                                    contImagen.MinimumSize = new Size(panelWidth - 20, 0);
                                    contImagen.Width = panelWidth - 20;
                                    //AjustarProporcionesPictureBox(contImagen, contImagen.Width);
                                }
                            }
                        }
                    }
                }
                
            }
        }

        private void AjustarTextBOX(object sender, EventArgs e)
        {
            // Define los tamaños máximos y mínimos
            int maxWidth = 605;
            int minWidth = 230;

            // Ajusta el tamaño del TextBox basado en el tamaño actual del FlowLayoutPanel
            int newWidth = flowLayoutPanel2.Width;

            // Asegúrate de que el nuevo tamaño esté dentro de los límites establecidos
            if (newWidth > maxWidth)
            {
            newWidth = maxWidth;
            }
            else if (newWidth < minWidth)
            {
                    newWidth = minWidth;
            }

            // Ajusta el ancho del TextBox
            textBox1.Width = newWidth-20;
        }

        private void AddPost(string content)
        {
                

///*
            // Crear un nuevo Panel para contener el post
            Panel postPanel = new Panel();
            postPanel.BackColor = Color.SeaShell;
            postPanel.BorderStyle = BorderStyle.FixedSingle;
            postPanel.Padding = new Padding(10);
            postPanel.Margin = new Padding(10);
            postPanel.AutoSize = true;
            postPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            postPanel.MaximumSize = new Size(flowLayoutPanel1.ClientSize.Width - 20, 0); // Ajustar el ancho máximo
            postPanel.Width = flowLayoutPanel1.ClientSize.Width - 20; // Establecer el ancho actual

            // Crear un FlowLayoutPanel para organizar los elementos dentro del postPanel
            FlowLayoutPanel flpPost = new FlowLayoutPanel();
            flpPost.FlowDirection = FlowDirection.TopDown;
            flpPost.WrapContents = false;
            flpPost.AutoSize = true;
            flpPost.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpPost.Width = postPanel.Width - 20;

            

            

            // Crear un Label para el contenido del post
            Label postLabel = new Label();
            
            postLabel.text = content;
            postLabel.AutoSize = true;
            postLabel.MaximumSize = new Size(postPanel.Width - 20, 0); // Ajustar el tamaño máximo del Label
            postLabel.Margin = new Padding(0, 0, 0, 10); // Margen inferior para separación

            // Agregar el Label al Panel
            flpPost.Controls.Add(postLabel);

            if (checkBox1.Checked)
            {
                // Si hay una imagen, agregarla al Panel
                OpenFileDialog abrirImagen = new OpenFileDialog();

                PictureBox contImagen = new PictureBox();
                contImagen.BorderStyle = BorderStyle.Fixed3D;
                contImagen.BackColor = Color.Silver;
                //contImagen.Margin = new Padding(0, 20, 0, 0);

                if (abrirImagen.ShowDialog() == DialogResult.OK)
                {
                    contImagen.ImageLocation = abrirImagen.FileName;
                    //contImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                    contImagen.SizeMode = PictureBoxSizeMode.Zoom;
                    contImagen.MaximumSize = new Size(postPanel.Width - 20, 200); // Ajustar tamaño máximo
                    contImagen.MinimumSize = new Size(postPanel.Width - 20, 0); // Establecer tamaño mínimo
                    contImagen.Width = postPanel.Width - 20; // Establecer el ancho actual del PictureBox
                    contImagen.Height = 200; // Ajustar la altura fija del PictureBox
                    //contImagen.Margin = new Padding(0, 10, 0, 0); // Margen superior para separación

                }
                flpPost.Controls.Add(contImagen);
            }

            // boton de like
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
            likesCountLabel.Text = "0 Likes";
            likesCountLabel.AutoSize = true;
            likesCountLabel.Margin = new Padding(0, 5, 0, 0);

            // Variable para almacenar el estado del Like y la cantidad de Likes
            bool isLiked = false;
            int likesCount = 0;

            // Evento de clic del botón de Like
            likeButton.Click += (s, e) => {
                if (isLiked)
                {
                    isLiked = false;
                    likesCount--;
                    likeButton.Text = "Like";
                }
                else
                {
                    isLiked = true;
                    likesCount++;
                    likeButton.Text = "Dislike";
                }
                likesCountLabel.Text = $"{likesCount} Likes";
            };

            // Agregar el botón de Like y el Label de Likes al likePanel
            likePanel.Controls.Add(likeButton);
            likePanel.Controls.Add(likesCountLabel);

            // Agregar el likePanel al FlowLayoutPanel
            flpPost.Controls.Add(likePanel);

            ///////////////////////
            
            postPanel.Controls.Add(flpPost);

            // Agregar el Panel al FlowLayoutPanel
            flowLayoutPanel1.Controls.Add(postPanel);
            //flowLayoutPanel1.ScrollControlIntoView(postPanel); // Desplazar automáticamente al nuevo post

            // Ajustar tamaños para asegurarse de que el nuevo post se ajusta correctamente
            AdjustPanelSizes();//*/


             

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

    
    }
