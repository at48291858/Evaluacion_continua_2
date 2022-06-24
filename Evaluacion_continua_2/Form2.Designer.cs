namespace Evaluacion_continua_2
{
    partial class frmAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.txtMaterno = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtParcial = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lsbMatricula = new System.Windows.Forms.ListBox();
            this.lsbPaterno = new System.Windows.Forms.ListBox();
            this.lsbMaterno = new System.Windows.Forms.ListBox();
            this.lsbNombres = new System.Windows.Forms.ListBox();
            this.lsbPromedio = new System.Windows.Forms.ListBox();
            this.lsbEstado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paterno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Materno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Examen Parcial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Examen Final";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Promedio";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(158, 11);
            this.txtMatricula.MaxLength = 20;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 23);
            this.txtMatricula.TabIndex = 7;
            this.txtMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatricula_KeyPress);
            // 
            // txtPaterno
            // 
            this.txtPaterno.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaterno.Location = new System.Drawing.Point(158, 38);
            this.txtPaterno.MaxLength = 20;
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(164, 23);
            this.txtPaterno.TabIndex = 8;
            this.txtPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParcial_KeyPress);
            // 
            // txtMaterno
            // 
            this.txtMaterno.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterno.Location = new System.Drawing.Point(158, 67);
            this.txtMaterno.MaxLength = 20;
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(164, 23);
            this.txtMaterno.TabIndex = 9;
            this.txtMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaterno_KeyPress);
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(158, 93);
            this.txtNombres.MaxLength = 20;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(164, 23);
            this.txtNombres.TabIndex = 10;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // txtParcial
            // 
            this.txtParcial.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParcial.Location = new System.Drawing.Point(158, 120);
            this.txtParcial.MaxLength = 20;
            this.txtParcial.Name = "txtParcial";
            this.txtParcial.Size = new System.Drawing.Size(70, 23);
            this.txtParcial.TabIndex = 11;
            this.txtParcial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParcial_KeyPress);
            // 
            // txtFinal
            // 
            this.txtFinal.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinal.Location = new System.Drawing.Point(158, 147);
            this.txtFinal.MaxLength = 20;
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(70, 23);
            this.txtFinal.TabIndex = 12;
            this.txtFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFinal_KeyPress);
            // 
            // txtPromedio
            // 
            this.txtPromedio.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromedio.Location = new System.Drawing.Point(158, 175);
            this.txtPromedio.MaxLength = 20;
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.ReadOnly = true;
            this.txtPromedio.Size = new System.Drawing.Size(70, 23);
            this.txtPromedio.TabIndex = 13;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Gray;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(423, 29);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(91, 26);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Gray;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(423, 64);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 26);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.BackColor = System.Drawing.Color.Gray;
            this.btnVisualizar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.ForeColor = System.Drawing.Color.White;
            this.btnVisualizar.Location = new System.Drawing.Point(423, 96);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(91, 26);
            this.btnVisualizar.TabIndex = 16;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Gray;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(423, 131);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 26);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lsbMatricula
            // 
            this.lsbMatricula.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbMatricula.FormattingEnabled = true;
            this.lsbMatricula.ItemHeight = 16;
            this.lsbMatricula.Location = new System.Drawing.Point(31, 232);
            this.lsbMatricula.Name = "lsbMatricula";
            this.lsbMatricula.Size = new System.Drawing.Size(67, 148);
            this.lsbMatricula.TabIndex = 18;
            // 
            // lsbPaterno
            // 
            this.lsbPaterno.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbPaterno.FormattingEnabled = true;
            this.lsbPaterno.ItemHeight = 16;
            this.lsbPaterno.Location = new System.Drawing.Point(104, 232);
            this.lsbPaterno.Name = "lsbPaterno";
            this.lsbPaterno.Size = new System.Drawing.Size(90, 148);
            this.lsbPaterno.TabIndex = 19;
            // 
            // lsbMaterno
            // 
            this.lsbMaterno.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbMaterno.FormattingEnabled = true;
            this.lsbMaterno.ItemHeight = 16;
            this.lsbMaterno.Location = new System.Drawing.Point(200, 232);
            this.lsbMaterno.Name = "lsbMaterno";
            this.lsbMaterno.Size = new System.Drawing.Size(90, 148);
            this.lsbMaterno.TabIndex = 20;
            // 
            // lsbNombres
            // 
            this.lsbNombres.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbNombres.FormattingEnabled = true;
            this.lsbNombres.ItemHeight = 16;
            this.lsbNombres.Location = new System.Drawing.Point(296, 232);
            this.lsbNombres.Name = "lsbNombres";
            this.lsbNombres.Size = new System.Drawing.Size(152, 148);
            this.lsbNombres.TabIndex = 21;
            // 
            // lsbPromedio
            // 
            this.lsbPromedio.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbPromedio.FormattingEnabled = true;
            this.lsbPromedio.ItemHeight = 16;
            this.lsbPromedio.Location = new System.Drawing.Point(454, 232);
            this.lsbPromedio.Name = "lsbPromedio";
            this.lsbPromedio.Size = new System.Drawing.Size(80, 148);
            this.lsbPromedio.TabIndex = 22;
            // 
            // lsbEstado
            // 
            this.lsbEstado.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbEstado.FormattingEnabled = true;
            this.lsbEstado.ItemHeight = 16;
            this.lsbEstado.Location = new System.Drawing.Point(540, 232);
            this.lsbEstado.Name = "lsbEstado";
            this.lsbEstado.Size = new System.Drawing.Size(102, 148);
            this.lsbEstado.TabIndex = 23;
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 406);
            this.ControlBox = false;
            this.Controls.Add(this.lsbEstado);
            this.Controls.Add(this.lsbPromedio);
            this.Controls.Add(this.lsbNombres);
            this.Controls.Add(this.lsbMaterno);
            this.Controls.Add(this.lsbPaterno);
            this.Controls.Add(this.lsbMatricula);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtParcial);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtMaterno);
            this.Controls.Add(this.txtPaterno);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAlumnos";
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.frmAlumnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.TextBox txtMaterno;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtParcial;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox lsbMatricula;
        private System.Windows.Forms.ListBox lsbPaterno;
        private System.Windows.Forms.ListBox lsbMaterno;
        private System.Windows.Forms.ListBox lsbNombres;
        private System.Windows.Forms.ListBox lsbPromedio;
        private System.Windows.Forms.ListBox lsbEstado;
    }
}