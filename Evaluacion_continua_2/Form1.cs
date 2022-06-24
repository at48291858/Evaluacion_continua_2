using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion_continua_2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos ventanaAlumnos = new frmAlumnos();
            ventanaAlumnos.ShowDialog();
        }

        private void trabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrabajadores ventanaTrabajadores = new frmTrabajadores();
            ventanaTrabajadores.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
