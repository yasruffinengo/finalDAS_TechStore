namespace Vista
{
    partial class frmCliente
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
            dgvClientes = new DataGridView();
            label4 = new Label();
            groupBox1 = new GroupBox();
            cmbTiposCliente = new ComboBox();
            label8 = new Label();
            txtDomicilio = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtDni = new TextBox();
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnGuardar = new Button();
            label7 = new Label();
            btnModificar = new Button();
            btnCambiarEstado = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(12, 125);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 62;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(728, 540);
            dgvClientes.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(811, 100);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 9;
            label4.Text = "Nuevo Cliente";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbTiposCliente);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtDomicilio);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtDni);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Location = new Point(811, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(432, 559);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // cmbTiposCliente
            // 
            cmbTiposCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTiposCliente.FormattingEnabled = true;
            cmbTiposCliente.Location = new Point(178, 407);
            cmbTiposCliente.Name = "cmbTiposCliente";
            cmbTiposCliente.Size = new Size(225, 33);
            cmbTiposCliente.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 415);
            label8.Name = "label8";
            label8.Size = new Size(131, 25);
            label8.TabIndex = 18;
            label8.Text = "Tipo de cliente:";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(158, 338);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(245, 31);
            txtDomicilio.TabIndex = 17;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(158, 265);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(245, 31);
            txtEmail.TabIndex = 16;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(158, 197);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(245, 31);
            txtTelefono.TabIndex = 15;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(158, 123);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(245, 31);
            txtDni.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 203);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 11;
            label3.Text = "Telefono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 344);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 13;
            label6.Text = "Domicilio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 271);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 12;
            label5.Text = "Email:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(158, 57);
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
            label2.Location = new Point(24, 129);
            label2.Name = "label2";
            label2.Size = new Size(43, 25);
            label2.TabIndex = 1;
            label2.Text = "Dni:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(291, 503);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label7
            // 
            label7.AccessibleRole = AccessibleRole.Sound;
            label7.AllowDrop = true;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.Location = new Point(12, 71);
            label7.Name = "label7";
            label7.Size = new Size(123, 36);
            label7.TabIndex = 11;
            label7.Text = "CLIENTES";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(425, 689);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 34);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnCambiarEstado
            // 
            btnCambiarEstado.Location = new Point(563, 689);
            btnCambiarEstado.Name = "btnCambiarEstado";
            btnCambiarEstado.Size = new Size(177, 34);
            btnCambiarEstado.TabIndex = 13;
            btnCambiarEstado.Text = "Cambiar estado";
            btnCambiarEstado.UseVisualStyleBackColor = true;
            btnCambiarEstado.Click += btnEliminar_Click;
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 747);
            Controls.Add(btnCambiarEstado);
            Controls.Add(btnModificar);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(dgvClientes);
            Name = "frmCliente";
            Text = "Clientes";
            Load += frmCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private Button btnGuardar;
        private Label label3;
        private Label label5;
        private TextBox txtDomicilio;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtDni;
        private Label label6;
        private Label label7;
        private Button btnModificar;
        private Button btnCambiarEstado;
        private ComboBox cmbTiposCliente;
        private Label label8;
    }
}