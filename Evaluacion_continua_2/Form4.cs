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
    public partial class frmTrabajadores : Form
    {
        private string[] cod = new string[10];
        private string[] paterno = new string[20];
        private string[] materno = new string[20];
        private string[] nombres = new string[20];
        private double[] sueldo = new double[20];
        private double[] descuento = new double[10];
        private double[] neto = new double[10];
        private double[] bono = new double[10];
        private double[] totalp = new double[10];
        private int i = 0;

        public frmTrabajadores()
        {
            InitializeComponent();
        }
        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cod[i] = txtCodigo.Text.Trim();
            paterno[i] =txtPaterno.Text.Trim();
            materno[i] =txtMaterno.Text.Trim();
            nombres[i] =txtNombres.Text.Trim();
            sueldo[i] =Convert.ToDouble(txtSueldo.Text.Trim());
            descuento[i] = Convert.ToDouble(sueldo[i] / 7.5);
            neto[i] = Convert.ToDouble(sueldo[i] - descuento[i]);

            txtDescuento.Text = descuento[i].ToString();
            txtNeto.Text = neto[i].ToString();

            RecibirBono(neto[i]);
            i++;

            MessageBox.Show("Registro Exitoso");
        }

        private void limpiarListas()
        {
            lsbCodigo.Items.Clear();
            lsbPaterno.Items.Clear();
            lsbMaterno.Items.Clear();
            lsbNombres.Items.Clear();
            lsbNetoPago.Items.Clear();
            lsbBono.Items.Clear();
            lsbTotalPago.Items.Clear();
        }

        private void limpiarTextBox()
        {
            foreach (Control t in this.Controls)
            {
                if (t is TextBox)
                {
                    t.Text = "";
                }
            }
            txtCodigo.Focus();

        }

        private void RecibirBono(double netop)
        {
            if (netop >= 2000)
            {
                bono[i] = 0;
                totalp[i] = neto[i];
            }
            
            else
            {
                bono[i] = 200;
                totalp[i] = neto[i] + bono[i];
            }

            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarTextBox();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            limpiarListas();
            for (int j = 0; j < i; j++)
            {
                lsbCodigo.Items.Add(cod[j]);
                lsbPaterno.Items.Add(paterno[j]);
                lsbMaterno.Items.Add(materno[j]);
                lsbNombres.Items.Add(nombres[j]);
                lsbNetoPago.Items.Add(neto[j]);
                lsbBono.Items.Add(bono[j]);
                lsbTotalPago.Items.Add(totalp[j]);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPaterno.Focus();
            }
        }

        private void txtPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtMaterno.Focus();
            }
        }

        private void txtMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNombres.Focus();
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtSueldo.Focus();
            }
        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnGuardar.Focus();
            }
        }

    }
}
