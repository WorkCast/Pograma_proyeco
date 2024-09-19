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
    public partial class FormCrearGrupo : Form
    {
        
        private Intereses intereses;
        private Usuario usuario;
        private Grupo grupo;
        private Grupos grupos;
        private Etiquetas etiquetas;
        int idEti1 = 0;
        int idEti2 = 0;
        int idEti3 = 0;
        string dirImg="";
        public FormCrearGrupo()
        {
            InitializeComponent();
            etiquetas = new Etiquetas();
            etiquetas.CargarEtiquetas();
            EtiquetasData.etiquetasData = etiquetas;
            intereses = new Intereses();
            usuario = UsuarioActual.usuario;
            grupo = new Grupo();
            grupos = GruposData.ListaGrupos;
        }

        private void CrearGrupo_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearGrupo_Click(object sender, EventArgs e)
        {
            if (ContarCbxSelecionados() < 1 || ContarCbxSelecionados() > 3||txtDescripcionGrupo.Text==""||txtNombreGrupo.Text==""||dirImg=="")
            {
                MessageBox.Show("Cantidad de intereces incorrecta o datos faltantes");
            }
            else
            {
                string desc = txtDescripcionGrupo.Text;
                string nom = txtNombreGrupo.Text;
                DevolverIdEtiquetas();

                intereses = DevolverIntereses();
                //MessageBox.Show(intereses.MostrarIntereces());
                Grupo g = new Grupo(grupos.NuevoIdGrupo(),Convert.ToInt32(UsuarioActual.usuario.id),nom,desc);
                g.intereses = intereses;
                g.dirImagen = dirImg;
                g.usuarios.AgregarUsuario(UsuarioActual.usuario);
                //MessageBox.Show(g.MostrarGrupo());
                GrupoActual.grupo = g;
                grupos.AgregarGrupo(g);
                GruposData.ListaGrupos = grupos;
                MessageBox.Show("Bien! Cresacion de grupo completa "+g.id);
                idEti1 = 0;
                idEti2 = 0;
                idEti3 = 0;
                dirImg = "";
            }
        }

        public int ContarCbxSelecionados()
        {
            int cuentaCbx = 0;

            for (int i = 1; i <= 16; i++)
            {
                CheckBox checkBox = this.Controls.Find("checkBox" + i, true).FirstOrDefault() as CheckBox;
                if (checkBox != null && checkBox.Checked)
                {
                    cuentaCbx += 1;
                }
            }

            return cuentaCbx;
        }
        public void DevolverIdEtiquetas()
        {
            int cuenta = 0;
            for (int i = 1; i <= 16; i++)
            {
                if (cuenta > 3)
                {
                    break;
                }
                CheckBox checkBox = this.Controls.Find("checkBox" + i, true).FirstOrDefault() as CheckBox;
                if (checkBox != null && checkBox.Checked)
                {


                    if (checkBox != null && checkBox.Checked)
                    {
                        cuenta += 1;

                        // Asignar el valor de i a las variables correspondientes según el valor de cuenta
                        if (cuenta == 1)
                        {
                            idEti1 = i;
                        }
                        else if (cuenta == 2)
                        {
                            idEti2 = i;
                        }
                        else if (cuenta == 3)
                        {
                            idEti3 = i;
                        }
                    }

                }
            }
            //linea de prueba
            //MessageBox.Show("Id 1 " + Convert.ToString(idEti1) + " Id 2 " + Convert.ToString(idEti2) + " Id 3 " + Convert.ToString(idEti3));
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

        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();
            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {

                dirImg = abrirImagen.FileName;
                pictureBox1.ImageLocation = dirImg;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreGrupo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
