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
    public partial class FormIntereses : Form
    {
        private Etiquetas etiquetas;
        private Intereses intereses;
        private Usuario usuario;
        int idEti1=0;
        int idEti2=0;
        int idEti3=0;
        public FormIntereses()
        {
            InitializeComponent();
            etiquetas = new Etiquetas();
            etiquetas.CargarEtiquetas();
            EtiquetasData.etiquetasData = etiquetas;
            usuario = UsuarioActual.usuario;
            intereses = new Intereses();
        }

        private void Siguiente_Click(object sender, EventArgs e)
        {

            if (ContarCbxSelecionados()<1|| ContarCbxSelecionados()>3)
            {
                MessageBox.Show("Cantidad de intereces incorrecta");
            }
            else
            {
                DevolverIdEtiquetas();

                intereses= DevolverIntereses();
                //MessageBox.Show(intereses.MostrarIntereces());
                usuario.intereses=intereses;
                FormVerGrupo formVG = new FormVerGrupo();
                
                MessageBox.Show("Bien! Registro completo ");
                idEti1 = 0;
                idEti2 = 0;
                idEti3 = 0;

                formVG.Show();
                this.Hide();
            }

            //MessageBox.Show(Convert.ToString(ContarCbxSelecionados()));
        }

        public int ContarCbxSelecionados()
        {
            int cuentaCbx=0;

            for (int i = 1; i <= 16; i++)
            {
                CheckBox checkBox = this.Controls.Find("checkBox" + i, true).FirstOrDefault() as CheckBox;
                if (checkBox != null && checkBox.Checked)
                {
                    cuentaCbx += 1;
                }
            }
            //MessageBox.Show("cuentaCbx "+Convert.ToString(cuentaCbx));
            return cuentaCbx;
        }
        public void DevolverIdEtiquetas()
        {
            int cuenta = 0;
            for (int i = 1; i <= 16; i++)
            {
                if (cuenta>3)
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
            //MessageBox.Show("DevolverIdEtiquetas() Id 1 " + Convert.ToString(idEti1)+ " Id 2 " + Convert.ToString(idEti2)+" Id 3 " + Convert.ToString(idEti3));
        }
        public Intereses DevolverIntereses()
        {
            
            Intereses inte = new Intereses();

            if (idEti1!=0)
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
            //MessageBox.Show("DevolverIntereses()" + inte.MostrarIntereces());
            return inte;
        }
    }
}
