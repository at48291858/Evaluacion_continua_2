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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "IDAT") && (txtContra.Text == "123"))
            {
                this.Visible = false;
                frmPrincipal princ = new frmPrincipal();
                princ.Show();

            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtContra.Focus();
            }
            
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnIngresar.Focus();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
