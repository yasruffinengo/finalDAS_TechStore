namespace Vista
{
    partial class frmDescuento
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
            dgvDescuentos = new DataGridView();
            label7 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            cmbTipoCliente = new ComboBox();
            nudValor = new NumericUpDown();
            cmbTipoDescuento = new ComboBox();
            label8 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnGuardar = new Button();
            btnCambiarEstado = new Button();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDescuentos).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudValor).BeginInit();
            SuspendLayout();
            // 
            // dgvDescuentos
            // 
            dgvDescuentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDescuentos.Location = new Point(39, 111);
            dgvDescuentos.Name = "dgvDescuentos";
            dgvDescuentos.RowHeadersWidth = 62;
            dgvDescuentos.Size = new Size(631, 475);
            dgvDescuentos.TabIndex = 0;
            // 
            // label7
            // 
            label7.AccessibleRole = AccessibleRole.Sound;
            label7.AllowDrop = true;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.Location = new Point(39, 55);
            label7.Name = "label7";
            label7.Size = new Size(173, 36);
            label7.TabIndex = 12;
            label7.Text = "DESCUENTOS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(692, 87);
            label4.Name = "label4";
            label4.Size = new Size(153, 25);
            label4.TabIndex = 13;
            label4.Text = "Nuevo Descuento";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbTipoCliente);
            groupBox1.Controls.Add(nudValor);
            groupBox1.Controls.Add(cmbTipoDescuento);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Location = new Point(692, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(472, 393);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // cmbTipoCliente
            // 
            cmbTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoCliente.FormattingEnabled = true;
            cmbTipoCliente.Location = new Point(211, 257);
            cmbTipoCliente.Name = "cmbTipoCliente";
            cmbTipoCliente.Size = new Size(245, 33);
            cmbTipoCliente.TabIndex = 20;
            // 
            // nudValor
            // 
            nudValor.DecimalPlaces = 2;
            nudValor.Location = new Point(211, 120);
            nudValor.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudValor.Name = "nudValor";
            nudValor.Size = new Size(245, 31);
            nudValor.TabIndex = 15;
            // 
            // cmbTipoDescuento
            // 
            cmbTipoDescuento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDescuento.FormattingEnabled = true;
            cmbTipoDescuento.Location = new Point(211, 184);
            cmbTipoDescuento.Name = "cmbTipoDescuento";
            cmbTipoDescuento.Size = new Size(245, 33);
            cmbTipoDescuento.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 260);
            label8.Name = "label8";
            label8.Size = new Size(131, 25);
            label8.TabIndex = 18;
            label8.Text = "Tipo de cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 192);
            label3.Name = "label3";
            label3.Size = new Size(163, 25);
            label3.TabIndex = 11;
            label3.Text = "Tipo de descuento:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(211, 54);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(245, 31);
            txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 60);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 126);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 1;
            label2.Text = "Valor:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(344, 328);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCambiarEstado
            // 
            btnCambiarEstado.Location = new Point(493, 602);
            btnCambiarEstado.Name = "btnCambiarEstado";
            btnCambiarEstado.Size = new Size(177, 34);
            btnCambiarEstado.TabIndex = 16;
            btnCambiarEstado.Text = "Cambiar estado";
            btnCambiarEstado.UseVisualStyleBackColor = true;
            btnCambiarEstado.Click += btnCambiarEstado_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(355, 602);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 34);
            btnModificar.TabIndex = 15;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // frmDescuento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 648);
            Controls.Add(btnCambiarEstado);
            Controls.Add(btnModificar);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(dgvDescuentos);
            Name = "frmDescuento";
            Text = "Descuentos";
            Load += frmDescuento_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDescuentos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudValor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDescuentos;
        private Label label7;
        private Label label4;
        private GroupBox groupBox1;
        private ComboBox cmbTipoDescuento;
        private Label label8;
        private Label label3;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private Button btnGuardar;
        private NumericUpDown nudValor;
        private ComboBox cmbTipoCliente;
        private Button btnCambiarEstado;
        private Button btnModificar;
    }
}