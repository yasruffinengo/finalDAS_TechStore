namespace Vista
{
    partial class frmSucursal
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
            dgvSucursales = new DataGridView();
            label4 = new Label();
            groupBox1 = new GroupBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtDomicilio = new TextBox();
            label3 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnGuardar = new Button();
            label7 = new Label();
            btnCambiarEstado = new Button();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSucursales
            // 
            dgvSucursales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSucursales.Location = new Point(38, 122);
            dgvSucursales.Name = "dgvSucursales";
            dgvSucursales.RowHeadersWidth = 62;
            dgvSucursales.Size = new Size(727, 468);
            dgvSucursales.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(184, -68);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 11;
            label4.Text = "Nuevo Cliente";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtDomicilio);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Location = new Point(820, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(432, 409);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
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
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(158, 123);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(245, 31);
            txtDomicilio.TabIndex = 14;
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
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Domicilio:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(291, 344);
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
            label7.Location = new Point(38, 68);
            label7.Name = "label7";
            label7.Size = new Size(167, 36);
            label7.TabIndex = 13;
            label7.Text = "SUCURSALES";
            label7.Click += label7_Click;
            // 
            // btnCambiarEstado
            // 
            btnCambiarEstado.Location = new Point(588, 612);
            btnCambiarEstado.Name = "btnCambiarEstado";
            btnCambiarEstado.Size = new Size(177, 34);
            btnCambiarEstado.TabIndex = 15;
            btnCambiarEstado.Text = "Cambiar estado";
            btnCambiarEstado.UseVisualStyleBackColor = true;
            btnCambiarEstado.Click += btnCambiarEstado_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(450, 612);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 34);
            btnModificar.TabIndex = 14;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // frmSucursal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 658);
            Controls.Add(btnCambiarEstado);
            Controls.Add(btnModificar);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(dgvSucursales);
            Name = "frmSucursal";
            Text = "Sucursales";
            Load += frmSucursal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSucursales;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtDomicilio;
        private Label label3;
        private Label label5;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private Button btnGuardar;
        private Label label7;
        private Button btnCambiarEstado;
        private Button btnModificar;
    }
}