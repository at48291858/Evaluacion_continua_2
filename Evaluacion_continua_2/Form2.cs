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
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private int[] matricula = new int[20];
        private string[] paterno = new string[20];
        private string[] materno = new string[20];
        private string[] nombres = new string[20];
        private double[] promedio = new double[20];
        private string[] estado = new string[20];
        private int i = 0;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            matricula[i] = Convert.ToInt32(txtMatricula.Text.Trim());  //Convertir a String
            paterno[i] = txtPaterno.Text.Trim();
            materno[i] = txtMaterno.Text.Trim();
            nombres[i] = txtNombres.Text.Trim();
            promedio[i] = (Convert.ToDouble(txtParcial.Text.Trim()) + Convert.ToDouble(txtFinal.Text.Trim())) / 2;

            txtPromedio.Text = promedio[i].ToString();//imprimiendo el promedio

            comprobarEstado(promedio[i]);//promedio = retirado || ayuda || promovido
            i++;//contador

            MessageBox.Show("Registro Guardado");
        }

        private void limpiarListas()
        {
            lsbMatricula.Items.Clear();
            lsbPaterno.Items.Clear();
            lsbMaterno.Items.Clear();
            lsbNombres.Items.Clear();
            lsbPromedio.Items.Clear();
            lsbEstado.Items.Clear();
        }

        private void limpiarCajas()
        {
            foreach (Control caja in this.Controls)
            {
                if (caja is TextBox)
                {
                    caja.Text = "";
                }
            }
            txtMatricula.Focus();
        }

        private void comprobarEstado(double prom){
            if (prom >= 0 && prom <=3)
            {
                estado[i] = "Retirado";
            }
            else if (prom > 3 && prom <= 10)
            {
                estado[i] = "Ayuda";
            }
            else
            {
                estado[i] = "Promovido";
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            limpiarListas();

            for (int j = 0; j < i; j++)
            {
                lsbMatricula.Items.Add(matricula[j]);
                lsbPaterno.Items.Add(paterno[j]);
                lsbMaterno.Items.Add(materno[j]);
                lsbNombres.Items.Add(nombres[j]);
                lsbPromedio.Items.Add(promedio[j]);
                lsbEstado.Items.Add(estado[j]);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCajas();
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
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
                txtParcial.Focus();
            }
        }

        private void txtParcial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtFinal.Focus();
            }
        }

        private void txtFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnGuardar.Focus();
            }
        }
    }
}
