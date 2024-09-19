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
    public partial class FormVerEventos : Form
    {
        Eventos eventos;
        public FormVerEventos()
        {
            InitializeComponent();
            eventos = GrupoActual.grupo.eventosGrupo;

            LoadEventos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LoadEventos();
        }

        private void LoadEventos()
        {
            flpEventos.Controls.Clear();
            lblNumEventos.Text = Convert.ToString(eventos.listaEventos.Count);
            foreach (Evento evento in eventos.listaEventos)
            {

                AddEventoPanel(evento);
            }
        }

        private void AddEventoPanel(Evento evento)
        {
            // Crear un nuevo Panel para contener la información del evento
            Panel eventoPanel = new Panel();

            // Establecer las propiedades del Panel
            eventoPanel.BackColor = Color.White;
            eventoPanel.BorderStyle = BorderStyle.FixedSingle;
            eventoPanel.Padding = new Padding(10);
            eventoPanel.Margin = new Padding(10);
            eventoPanel.AutoSize = true;
            eventoPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            eventoPanel.MaximumSize = new Size(flpEventos.ClientSize.Width - 20, 0); // Ajustar el ancho máximo
            eventoPanel.Width = flpEventos.ClientSize.Width - 20; // Establecer el ancho actual

            // Crear un FlowLayoutPanel para organizar los elementos dentro del eventoPanel
            FlowLayoutPanel flpEvento = new FlowLayoutPanel();
            flpEvento.FlowDirection = FlowDirection.LeftToRight;
            flpEvento.WrapContents = false;
            flpEvento.AutoSize = true;
            flpEvento.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpEvento.Width = eventoPanel.Width - 20; // Restar márgenes

            // Crear un PictureBox para la imagen del evento
            PictureBox pbImagenEvento = new PictureBox();
            pbImagenEvento.SizeMode = PictureBoxSizeMode.Zoom;
            pbImagenEvento.ImageLocation = evento.dirImagen;
            pbImagenEvento.BorderStyle = BorderStyle.Fixed3D;
            pbImagenEvento.BackColor = Color.LightGray;
            pbImagenEvento.Size = new Size(150, 150); // Ajustar el tamaño del PictureBox

            // Crear un FlowLayoutPanel adicional para los TextBox (uno debajo del otro)
            FlowLayoutPanel flpTextBoxes = new FlowLayoutPanel();
            flpTextBoxes.FlowDirection = FlowDirection.TopDown;
            flpTextBoxes.AutoSize = true;
            flpTextBoxes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpTextBoxes.Padding = new Padding(10);
            flpTextBoxes.Width = flpEvento.Width - pbImagenEvento.Width - 40; // Ajustar el ancho restante para los TextBox

            // Crear los TextBox para el nombre, el lugar y la fecha del evento
            TextBox txtNombre = new TextBox();
            txtNombre.Text = "Nombre del evento: " + evento.nombre;
            txtNombre.Width = flpTextBoxes.Width - 20;
            txtNombre.Margin = new Padding(0, 5, 0, 10);

            TextBox txtLugar = new TextBox();
            txtLugar.Text = "Lugar: " + evento.lugar;
            txtLugar.Width = flpTextBoxes.Width - 20;
            txtLugar.Margin = new Padding(0, 5, 0, 10);

            TextBox txtFecha = new TextBox();
            txtFecha.Text = "Fecha: " + evento.fechaEvento;
            txtFecha.Width = flpTextBoxes.Width - 20;
            txtFecha.Margin = new Padding(0, 5, 0, 10);

            // Agregar los TextBox al FlowLayoutPanel
            flpTextBoxes.Controls.Add(txtNombre);
            flpTextBoxes.Controls.Add(txtLugar);
            flpTextBoxes.Controls.Add(txtFecha);

            // Agregar el PictureBox y el FlowLayoutPanel de TextBoxes al FlowLayoutPanel del evento
            flpEvento.Controls.Add(pbImagenEvento);
            flpEvento.Controls.Add(flpTextBoxes);

            // Agregar el FlowLayoutPanel al Panel del evento
            eventoPanel.Controls.Add(flpEvento);

            // Agregar el Panel del evento al FlowLayoutPanel de eventos (flpEventos)
            flpEventos.Controls.Add(eventoPanel);
        }
    }
}
