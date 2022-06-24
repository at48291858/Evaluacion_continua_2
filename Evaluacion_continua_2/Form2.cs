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

        private string[] matricula = new string[20];
        private string[] paterno = new string[20];
        private string[] materno = new string[20];
        private string[] nombres = new string[20];
        private double[] promedio = new double[20];
        private string[] estado = new string[20];
        private int i = 0;
        private string conte = "";


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            matricula[i] = txtMatricula.Text.Trim();  //Convertir a String
            paterno[i] = txtPaterno.Text.Trim();
            materno[i] = txtMaterno.Text.Trim();
            nombres[i] = txtNombres.Text.Trim();
            promedio[i] = (Convert.ToDouble(txtParcial.Text.Trim()) + Convert.ToDouble(txtFinal.Text.Trim())) / 2;

            txtPromedio.Text = promedio[i].ToString();//imprimiendo el promedio

            comprobarEstado(promedio[i]);//promedio = retirado || ayuda || promovido
            i++;//contador

            conte = txtPaterno.Text.Substring(0, 1) + txtMaterno.Text.Substring(0, 1) + txtNombres.Text.Substring(0, 1) + "000" + Convert.ToString(i);


            MessageBox.Show("Registro Guardado");
        }

        private void limpiarListas()
        {
            lsbMatricula.Items.Clear();
            lsbPaterno.Items.Clear();
            lsbMaterno.Items.Clear();
            lsbNombres.Items.Clear();
            lsbPromedio.Items.Clear();
            lsbEstado.Items.Clear();//limpia los listbox
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

        private void validarLetras(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 58 && e.KeyChar <= 122))
            {
                MessageBox.Show("Solo se permite ingresar letras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
        private void validarNumeros(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permite ingresar numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
           limpiarCajas();
           txtMatricula.Text = Convert.ToString(i + 1);
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
            validarLetras(e);

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtMaterno.Focus();
            }
        }

        private void txtMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarLetras(e);

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNombres.Focus();
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarLetras(e);

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtParcial.Focus();
            }
        }

        private void txtParcial_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumeros(e);

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtFinal.Focus();
            }
        }

        private void txtFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumeros(e);

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnGuardar.Focus();
            }
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            txtMatricula.Text = "0001";
        }
    }
}
