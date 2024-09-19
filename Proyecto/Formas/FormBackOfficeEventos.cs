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
    public partial class FormBackOfficeEventos : Form
    {
        private Eventos eventos;
        private Intereses intereses;
        private Grupos grupos;
        private Grupo grupo;
        private int selectedEve = -1;
        private Timer timer;
        string dirImg = "";
        
        public FormBackOfficeEventos()
        {
            InitializeComponent();
            eventos = EventosData.listaEventos;
            intereses = new Intereses();
            grupos = GruposData.ListaGrupos;
            grupo = new Grupo();
            InicializarTimer();
        }

        

        private void FormBackOfficeEventos_Load(object sender, EventArgs e)
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

        private void btnCrearEvento_Click(object sender, EventArgs e)
        {
            bool existeGrupo = grupos.ExisteGrupo(Convert.ToInt32( txtIdGrupo.Text));
            
            if (dirImg == "" || txtDescripcion.Text == "" || txtFechaHora.Text == "" || !eventos.ValidarFechaHoraFormato(txtFechaHora.Text) || txtLugar.Text == "" || txtNombreE.Text == ""||txtIdGrupo.Text == ""|| !existeGrupo)
            {
                MessageBox.Show("faltan datos");
            }
            else
            {
                int idG = Convert.ToInt32(txtIdGrupo.Text);
                string lugar = txtLugar.Text;
                string desc = txtDescripcion.Text;
                string fechaH = txtFechaHora.Text;
                string nom = txtNombreE.Text;
                MessageBox.Show(dirImg);
                Evento ev = new Evento(eventos.NuevoId(),idG, lugar, desc, fechaH, nom, dirImg);
                grupo = grupos.ObtenerPorId(Convert.ToInt32(txtIdGrupo.Text));
                ev.intereses = grupo.intereses;
                //MessageBox.Show(ev.MostrarEvento());
                eventos.AgregarEvento(ev);

                EventosData.listaEventos = eventos;
                grupo.eventosGrupo.AgregarEvento(ev);
                MessageBox.Show("evento creado con exito");
                dirImg = "";
                selectedEve = -1;
                listEventos.SelectedIndex = -1;
            }
        }

        private void LoadEventos()
        {
            listEventos.Items.Clear();
            
            foreach (Evento eve in eventos.listaEventos)
            {
                listEventos.Items.Add(eve.MostrarEvento());
            }

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
            lblP.Text =Convert.ToString( selectedEve);
            if (selectedEve == -1)
            {
                // Código para actualizar el formulario
                LoadEventos();
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            

            if (selectedEve==-1||dirImg == "" || txtDescripcion.Text == "" || txtFechaHora.Text == "" ||!eventos.ValidarFechaHoraFormato(txtFechaHora.Text) || txtLugar.Text == "" || txtNombreE.Text == "" || txtIdGrupo.Text == "")
            {
                MessageBox.Show("faltan datos o no esta selecionado un evento");
            }
            else
            {
                int idG = Convert.ToInt32(txtIdGrupo.Text);
                string lugar = txtLugar.Text;
                string desc = txtDescripcion.Text;
                string fechaH = txtFechaHora.Text;
                string nom = txtNombreE.Text;

                eventos.ModificarEvento(Convert.ToInt32( GetSelectedEveId()),desc,nom,lugar,fechaH,dirImg);
                grupo = grupos.ObtenerPorId(Convert.ToInt32(txtIdGrupo.Text));
                EventosData.listaEventos = eventos;
                grupo.eventosGrupo.ModificarEvento(Convert.ToInt32( GetSelectedEveId()),desc,nom,lugar,fechaH,dirImg);
                MessageBox.Show("evento modificado con exito");
                dirImg = "";
                selectedEve = -1;
                listEventos.SelectedIndex = -1;
            }
        }

        private int GetSelectedEveId()
        {

            if (listEventos.SelectedItem!=null)
            {
                string selectedEve = listEventos.SelectedItem.ToString();
                int colonIndex = selectedEve.IndexOf(" - ");
                return int.Parse(selectedEve.Substring(0, colonIndex));
            }

            return 0;
        }

        private void listEventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listEventos.SelectedItem != null) 
            { 
                selectedEve = listEventos.SelectedIndex;
                lblIdEvento.Text = Convert.ToString( GetSelectedEveId());
                txtDescripcion.Text = eventos.ObtenerEventoPorId(GetSelectedEveId()).descripcion;
                txtFechaHora.Text = eventos.ObtenerEventoPorId(GetSelectedEveId()).fechaEvento;
                txtIdGrupo.Text = Convert.ToString(eventos.ObtenerEventoPorId(GetSelectedEveId()).idGrupo);
                txtLugar.Text = eventos.ObtenerEventoPorId(GetSelectedEveId()).lugar;
                txtNombreE.Text = eventos.ObtenerEventoPorId(GetSelectedEveId()).nombre;
                dirImg = eventos.ObtenerEventoPorId(GetSelectedEveId()).dirImagen;
                pictureBoxFoto.ImageLocation = dirImg;
            }
        }

        private void btnBorrarEve_Click(object sender, EventArgs e)
        {
            if (selectedEve==-1||txtIdGrupo.Text=="")
            {
                MessageBox.Show("no seleciono ningun evento o el campo id grupo esta vacio");
            }
            else
            {
                grupo = grupos.ObtenerPorId(Convert.ToInt32(txtIdGrupo.Text));
                grupo.eventosGrupo.EliminarEvento(GetSelectedEveId());
                eventos.EliminarEvento(GetSelectedEveId());
                selectedEve = -1;
                listEventos.SelectedIndex = -1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedEve = -1;
            listEventos.SelectedIndex = -1;
        }
    }
}
