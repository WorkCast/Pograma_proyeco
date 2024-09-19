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
    public partial class FormAdministracion : Form
    {
        public FormAdministracion()
        {
            InitializeComponent();
        }

        private void btnBackPosts_Click(object sender, EventArgs e)
        {
            FormBackoffice formP = new FormBackoffice();
            formP.Show();
        }

        private void btnBackUsuarios_Click(object sender, EventArgs e)
        {
            FormBackOfficeUsr formU = new FormBackOfficeUsr();
            formU.Show();
        }

        private void btnBackEventos_Click(object sender, EventArgs e)
        {
            FormBackOfficeEventos formE = new FormBackOfficeEventos();
            formE.Show();
        }

        private void btnBackGrupos_Click(object sender, EventArgs e)
        {
            FormBackOficeGrupos formG = new FormBackOficeGrupos();
            formG.Show();
        }
    }
}
