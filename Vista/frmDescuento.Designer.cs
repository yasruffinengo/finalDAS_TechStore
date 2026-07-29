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
            txtDescripcion = new TextBox();
            label5 = new Label();
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
            dgvDescuentos.Location = new Point(31, 89);
            dgvDescuentos.Margin = new Padding(2, 2, 2, 2);
            dgvDescuentos.MultiSelect = false;
            dgvDescuentos.Name = "dgvDescuentos";
            dgvDescuentos.ReadOnly = true;
            dgvDescuentos.RowHeadersWidth = 62;
            dgvDescuentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDescuentos.Size = new Size(692, 380);
            dgvDescuentos.TabIndex = 0;
            dgvDescuentos.CellContentClick += dgvDescuentos_CellContentClick;
            // 
            // label7
            // 
            label7.AccessibleRole = AccessibleRole.Sound;
            label7.AllowDrop = true;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.Location = new Point(31, 44);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(147, 30);
            label7.TabIndex = 12;
            label7.Text = "DESCUENTOS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(762, 69);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 13;
            label4.Text = "Nuevo Descuento";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbTipoCliente);
            groupBox1.Controls.Add(nudValor);
            groupBox1.Controls.Add(cmbTipoDescuento);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Location = new Point(762, 91);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(378, 355);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(169, 98);
            txtDescripcion.Margin = new Padding(2, 2, 2, 2);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(197, 27);
            txtDescripcion.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 103);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 21;
            label5.Text = "Descripcion:";
            // 
            // cmbTipoCliente
            // 
            cmbTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoCliente.FormattingEnabled = true;
            cmbTipoCliente.Location = new Point(169, 262);
            cmbTipoCliente.Margin = new Padding(2, 2, 2, 2);
            cmbTipoCliente.Name = "cmbTipoCliente";
            cmbTipoCliente.Size = new Size(197, 28);
            cmbTipoCliente.TabIndex = 20;
            // 
            // nudValor
            // 
            nudValor.DecimalPlaces = 2;
            nudValor.Location = new Point(169, 152);
            nudValor.Margin = new Padding(2, 2, 2, 2);
            nudValor.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudValor.Name = "nudValor";
            nudValor.Size = new Size(196, 27);
            nudValor.TabIndex = 15;
            // 
            // cmbTipoDescuento
            // 
            cmbTipoDescuento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDescuento.FormattingEnabled = true;
            cmbTipoDescuento.Location = new Point(169, 203);
            cmbTipoDescuento.Margin = new Padding(2, 2, 2, 2);
            cmbTipoDescuento.Name = "cmbTipoDescuento";
            cmbTipoDescuento.Size = new Size(197, 28);
            cmbTipoDescuento.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 264);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(111, 20);
            label8.TabIndex = 18;
            label8.Text = "Tipo de cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 210);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 11;
            label3.Text = "Tipo de descuento:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(169, 43);
            txtNombre.Margin = new Padding(2, 2, 2, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(197, 27);
            txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 48);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 157);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Valor:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(275, 318);
            btnGuardar.Margin = new Padding(2, 2, 2, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 27);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCambiarEstado
            // 
            btnCambiarEstado.Location = new Point(582, 482);
            btnCambiarEstado.Margin = new Padding(2, 2, 2, 2);
            btnCambiarEstado.Name = "btnCambiarEstado";
            btnCambiarEstado.Size = new Size(142, 27);
            btnCambiarEstado.TabIndex = 16;
            btnCambiarEstado.Text = "Cambiar estado";
            btnCambiarEstado.UseVisualStyleBackColor = true;
            btnCambiarEstado.Click += btnCambiarEstado_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(471, 482);
            btnModificar.Margin = new Padding(2, 2, 2, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(90, 27);
            btnModificar.TabIndex = 15;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // frmDescuento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 518);
            Controls.Add(btnCambiarEstado);
            Controls.Add(btnModificar);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(dgvDescuentos);
            Margin = new Padding(2, 2, 2, 2);
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
        private TextBox txtDescripcion;
        private Label label5;
    }
}