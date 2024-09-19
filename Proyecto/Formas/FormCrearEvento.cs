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
    public partial class FormCrearEvento : Form
    {
        //Evento evento;
        Eventos eventos;
        Grupo grupo;
        string dirImg;
        public FormCrearEvento()
        {
            InitializeComponent();
            //evento = new Evento();
            eventos = EventosData.listaEventos;
            grupo = GrupoActual.grupo;
            dirImg = "";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearEvento_Click(object sender, EventArgs e)
        {
            if (dirImg==""||txtDescripcion.Text==""||txtFechaHora.Text==""|| !eventos.ValidarFechaHoraFormato(txtFechaHora.Text) || txtLugar.Text==""||txtNombreE.Text=="")
            {
                MessageBox.Show("faltan datos");
            }
            else
            {
                string lugar = txtLugar.Text;
                string desc = txtDescripcion.Text;
                string fechaH = txtFechaHora.Text;
                string nom = txtNombreE.Text;
                Evento ev = new Evento(eventos.NuevoId(),lugar,desc,fechaH,nom,dirImg);
                //MessageBox.Show(ev.MostrarEvento());
                eventos.AgregarEvento(ev);
                
                EventosData.listaEventos = eventos;
                grupo.eventosGrupo.AgregarEvento(ev);
                MessageBox.Show("evento creado con exito");
                dirImg = "";
                
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();
            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {

                dirImg = abrirImagen.FileName;
                pictureBoxFoto.ImageLocation = dirImg;
            }
        }
    }
}
