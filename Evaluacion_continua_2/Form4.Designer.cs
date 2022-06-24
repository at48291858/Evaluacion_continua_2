namespace Evaluacion_continua_2
{
    partial class frmTrabajadores
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.txtMaterno = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbListas = new System.Windows.Forms.GroupBox();
            this.lsbTotalPago = new System.Windows.Forms.ListBox();
            this.lsbBono = new System.Windows.Forms.ListBox();
            this.lsbNetoPago = new System.Windows.Forms.ListBox();
            this.lsbNombres = new System.Windows.Forms.ListBox();
            this.lsbMaterno = new System.Windows.Forms.ListBox();
            this.lsbPaterno = new System.Windows.Forms.ListBox();
            this.lsbCodigo = new System.Windows.Forms.ListBox();
            this.gbListas.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paterno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Materno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sueldo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Descuento 7.5%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Neto Pago";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(151, 30);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(82, 23);
            this.txtCodigo.TabIndex = 7;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtPaterno
            // 
            this.txtPaterno.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaterno.Location = new System.Drawing.Point(151, 56);
            this.txtPaterno.MaxLength = 20;
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(174, 23);
            this.txtPaterno.TabIndex = 8;
            this.txtPaterno.TextChanged += new System.EventHandler(this.txtPaterno_TextChanged);
            this.txtPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaterno_KeyPress);
            // 
            // txtMaterno
            // 
            this.txtMaterno.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterno.Location = new System.Drawing.Point(151, 82);
            this.txtMaterno.MaxLength = 20;
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(176, 23);
            this.txtMaterno.TabIndex = 9;
            this.txtMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaterno_KeyPress);
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(151, 108);
            this.txtNombres.MaxLength = 20;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(176, 23);
            this.txtNombres.TabIndex = 10;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // txtSueldo
            // 
            this.txtSueldo.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldo.Location = new System.Drawing.Point(151, 137);
            this.txtSueldo.MaxLength = 10;
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(60, 23);
            this.txtSueldo.TabIndex = 11;
            this.txtSueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldo_KeyPress);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(151, 166);
            this.txtDescuento.MaxLength = 10;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(60, 23);
            this.txtDescuento.TabIndex = 12;
            // 
            // txtNeto
            // 
            this.txtNeto.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNeto.Location = new System.Drawing.Point(151, 195);
            this.txtNeto.MaxLength = 10;
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.ReadOnly = true;
            this.txtNeto.Size = new System.Drawing.Size(60, 23);
            this.txtNeto.TabIndex = 13;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Gray;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(459, 32);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(98, 24);
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
            this.btnGuardar.Location = new System.Drawing.Point(459, 67);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 24);
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
            this.btnVisualizar.Location = new System.Drawing.Point(459, 103);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(98, 24);
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
            this.btnSalir.Location = new System.Drawing.Point(459, 136);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(98, 24);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbListas
            // 
            this.gbListas.Controls.Add(this.lsbTotalPago);
            this.gbListas.Controls.Add(this.lsbBono);
            this.gbListas.Controls.Add(this.lsbNetoPago);
            this.gbListas.Controls.Add(this.lsbNombres);
            this.gbListas.Controls.Add(this.lsbMaterno);
            this.gbListas.Controls.Add(this.lsbPaterno);
            this.gbListas.Controls.Add(this.lsbCodigo);
            this.gbListas.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListas.Location = new System.Drawing.Point(27, 224);
            this.gbListas.Name = "gbListas";
            this.gbListas.Size = new System.Drawing.Size(789, 218);
            this.gbListas.TabIndex = 25;
            this.gbListas.TabStop = false;
            this.gbListas.Text = "Listas";
            // 
            // lsbTotalPago
            // 
            this.lsbTotalPago.FormattingEnabled = true;
            this.lsbTotalPago.ItemHeight = 16;
            this.lsbTotalPago.Location = new System.Drawing.Point(642, 19);
            this.lsbTotalPago.Name = "lsbTotalPago";
            this.lsbTotalPago.Size = new System.Drawing.Size(120, 180);
            this.lsbTotalPago.TabIndex = 31;
            // 
            // lsbBono
            // 
            this.lsbBono.FormattingEnabled = true;
            this.lsbBono.ItemHeight = 16;
            this.lsbBono.Location = new System.Drawing.Point(546, 19);
            this.lsbBono.Name = "lsbBono";
            this.lsbBono.Size = new System.Drawing.Size(90, 180);
            this.lsbBono.TabIndex = 30;
            // 
            // lsbNetoPago
            // 
            this.lsbNetoPago.FormattingEnabled = true;
            this.lsbNetoPago.ItemHeight = 16;
            this.lsbNetoPago.Location = new System.Drawing.Point(458, 19);
            this.lsbNetoPago.Name = "lsbNetoPago";
            this.lsbNetoPago.Size = new System.Drawing.Size(82, 180);
            this.lsbNetoPago.TabIndex = 29;
            // 
            // lsbNombres
            // 
            this.lsbNombres.FormattingEnabled = true;
            this.lsbNombres.ItemHeight = 16;
            this.lsbNombres.Location = new System.Drawing.Point(331, 19);
            this.lsbNombres.Name = "lsbNombres";
            this.lsbNombres.Size = new System.Drawing.Size(121, 180);
            this.lsbNombres.TabIndex = 28;
            // 
            // lsbMaterno
            // 
            this.lsbMaterno.FormattingEnabled = true;
            this.lsbMaterno.ItemHeight = 16;
            this.lsbMaterno.Location = new System.Drawing.Point(212, 19);
            this.lsbMaterno.Name = "lsbMaterno";
            this.lsbMaterno.Size = new System.Drawing.Size(113, 180);
            this.lsbMaterno.TabIndex = 27;
            // 
            // lsbPaterno
            // 
            this.lsbPaterno.FormattingEnabled = true;
            this.lsbPaterno.ItemHeight = 16;
            this.lsbPaterno.Location = new System.Drawing.Point(93, 19);
            this.lsbPaterno.Name = "lsbPaterno";
            this.lsbPaterno.Size = new System.Drawing.Size(113, 180);
            this.lsbPaterno.TabIndex = 26;
            // 
            // lsbCodigo
            // 
            this.lsbCodigo.FormattingEnabled = true;
            this.lsbCodigo.ItemHeight = 16;
            this.lsbCodigo.Location = new System.Drawing.Point(15, 19);
            this.lsbCodigo.Name = "lsbCodigo";
            this.lsbCodigo.Size = new System.Drawing.Size(72, 180);
            this.lsbCodigo.TabIndex = 25;
            // 
            // frmTrabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 446);
            this.ControlBox = false;
            this.Controls.Add(this.gbListas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtNeto);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtMaterno);
            this.Controls.Add(this.txtPaterno);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTrabajadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabajadores";
            this.gbListas.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.TextBox txtMaterno;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtNeto;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbListas;
        private System.Windows.Forms.ListBox lsbTotalPago;
        private System.Windows.Forms.ListBox lsbBono;
        private System.Windows.Forms.ListBox lsbNetoPago;
        private System.Windows.Forms.ListBox lsbNombres;
        private System.Windows.Forms.ListBox lsbMaterno;
        private System.Windows.Forms.ListBox lsbPaterno;
        private System.Windows.Forms.ListBox lsbCodigo;
    }
}