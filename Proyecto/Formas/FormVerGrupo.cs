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
    public partial class FormVerGrupo : Form
    {
        private Grupos grupos;
        public FormVerGrupo()
        {
            InitializeComponent();
            grupos = GruposData.ListaGrupos;
            LoadGrupos();
        }

        private void CrearGrupo_Click(object sender, EventArgs e)
        {
            FormCrearGrupo formCG = new FormCrearGrupo();
            formCG.Show();
            //this.Hide();
        }

        private void LoadGrupos()
        {
            grupos = GruposData.ListaGrupos;
            lblNumGrupos.Text = Convert.ToString( grupos.grupos.Count);
            
            flpGrupos.Controls.Clear();
            foreach (Grupo grupo in grupos.grupos)
            {
                //MessageBox.Show(grupo.MostrarGrupo());
                AddGrupoPanel(grupo);
            }
        }

        

        private void AddGrupoPanel(Grupo grupo)
        {
            // Crear un nuevo Panel para contener la información del grupo
            Panel grupoPanel = new Panel();

            // Establecer las propiedades del Panel
            grupoPanel.BackColor = Color.White;
            grupoPanel.BorderStyle = BorderStyle.FixedSingle;
            grupoPanel.Padding = new Padding(10);
            grupoPanel.Margin = new Padding(10);
            grupoPanel.AutoSize = true;
            grupoPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            grupoPanel.MaximumSize = new Size(flpGrupos.ClientSize.Width - 20, 0); // Ajustar el ancho máximo
            grupoPanel.Width = flpGrupos.ClientSize.Width - 20; // Establecer el ancho actual

            // Crear un FlowLayoutPanel para organizar los elementos dentro del grupoPanel
            FlowLayoutPanel flpGrupo = new FlowLayoutPanel();
            flpGrupo.FlowDirection = FlowDirection.LeftToRight;
            flpGrupo.WrapContents = false;
            flpGrupo.AutoSize = true;
            flpGrupo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpGrupo.Width = grupoPanel.Width - 20; // Restar márgenes

            // Crear un PictureBox para la imagen del grupo (placeholder)
            PictureBox pbImagenGrupo = new PictureBox();
            pbImagenGrupo.SizeMode = PictureBoxSizeMode.Zoom;
            pbImagenGrupo.ImageLocation = grupo.dirImagen;
            pbImagenGrupo.BorderStyle = BorderStyle.Fixed3D;
            pbImagenGrupo.BackColor = Color.LightGray; // Puedes cambiar este color de fondo
            //pbImagenGrupo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagenGrupo.Size = new Size(200, 200); // Ajustar el tamaño del PictureBox

            pbImagenGrupo.Click += (sender, e) =>
            {
                // Asignar el grupo actual al hacer clic
                
                if (!grupo.usuarios.ExisteUser(Convert.ToInt32(UsuarioActual.usuario.id)))
                {
                    grupo.usuarios.AgregarUsuario(UsuarioActual.usuario);
                }
                
                GrupoActual.grupo = grupo;

                // Abrir el formulario FormMuroGrupo
                FormMuroGrupo formMuro = new FormMuroGrupo();
                formMuro.Show();
            };

            // Crear un FlowLayoutPanel adicional para los TextBox (uno debajo del otro)
            FlowLayoutPanel flpTextBoxes = new FlowLayoutPanel();
            flpTextBoxes.FlowDirection = FlowDirection.TopDown; // Asegurar que los TextBox aparezcan uno bajo el otro
            flpTextBoxes.AutoSize = true;
            flpTextBoxes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpTextBoxes.Padding = new Padding(10);
            flpTextBoxes.Width = flpGrupo.Width - pbImagenGrupo.Width - 40; // Ajustar el ancho restante para los TextBox

            // Crear los TextBox para el nombre, la descripción y los intereses del grupo
            TextBox txtNombre = new TextBox();
            txtNombre.Text = "Nombre del grupo: " + grupo.nombre;  // Concatenar el nombre del grupo
            txtNombre.Width = flpTextBoxes.Width - 20;
            txtNombre.Margin = new Padding(0, 5, 0, 10); // Margen superior e inferior

            TextBox txtDescripcion = new TextBox();
            txtDescripcion.Text = "Descripción: " + grupo.descripcion;  // Concatenar la descripción del grupo
            txtDescripcion.Width = flpTextBoxes.Width - 20;
            txtDescripcion.Margin = new Padding(0, 5, 0, 10); // Margen superior e inferior

            TextBox txtIntereses = new TextBox();
            txtIntereses.Text = "Intereses: " + grupo.intereses.MostrarIntereces();  // Concatenar los intereses del grupo
            txtIntereses.Width = flpTextBoxes.Width - 20;
            txtIntereses.Margin = new Padding(0, 5, 0, 10); // Margen superior e inferior

            // Agregar los TextBox al FlowLayoutPanel
            flpTextBoxes.Controls.Add(txtNombre);
            flpTextBoxes.Controls.Add(txtDescripcion);
            flpTextBoxes.Controls.Add(txtIntereses);

            // Agregar el PictureBox y el FlowLayoutPanel de TextBoxes al FlowLayoutPanel del grupo
            flpGrupo.Controls.Add(pbImagenGrupo);
            flpGrupo.Controls.Add(flpTextBoxes);

            // Agregar el FlowLayoutPanel al Panel del grupo
            grupoPanel.Controls.Add(flpGrupo);

            // Agregar el Panel del grupo al FlowLayoutPanel de grupos (flpGrupos)
            flpGrupos.Controls.Add(grupoPanel);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
            LoadGrupos();
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
