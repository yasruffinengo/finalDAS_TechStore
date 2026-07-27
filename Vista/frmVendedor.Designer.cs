namespace Vista
{
    partial class frmVendedor
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
            groupBox1 = new GroupBox();
            cmbSucursales = new ComboBox();
            label3 = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnGuardar = new Button();
            btnCambiarEstado = new Button();
            btnModificar = new Button();
            label7 = new Label();
            dgvVendedores = new DataGridView();
            txtDni = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDni);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbSucursales);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Location = new Point(957, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(432, 390);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // cmbSucursales
            // 
            cmbSucursales.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSucursales.FormattingEnabled = true;
            cmbSucursales.Location = new Point(158, 253);
            cmbSucursales.Name = "cmbSucursales";
            cmbSucursales.Size = new Size(245, 33);
            cmbSucursales.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 261);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 15;
            label3.Text = "Sucursal:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(158, 123);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(245, 31);
            txtApellido.TabIndex = 14;
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
            label2.Size = new Size(82, 25);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            label2.Click += label2_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(291, 316);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCambiarEstado
            // 
            btnCambiarEstado.Location = new Point(742, 585);
            btnCambiarEstado.Name = "btnCambiarEstado";
            btnCambiarEstado.Size = new Size(177, 34);
            btnCambiarEstado.TabIndex = 19;
            btnCambiarEstado.Text = "Cambiar estado";
            btnCambiarEstado.UseVisualStyleBackColor = true;
            btnCambiarEstado.Click += btnCambiarEstado_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(604, 585);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 34);
            btnModificar.TabIndex = 18;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // label7
            // 
            label7.AccessibleRole = AccessibleRole.Sound;
            label7.AllowDrop = true;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.Location = new Point(12, 29);
            label7.Name = "label7";
            label7.Size = new Size(175, 36);
            label7.TabIndex = 17;
            label7.Text = "VENDEDORES";
            // 
            // dgvVendedores
            // 
            dgvVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVendedores.Location = new Point(12, 83);
            dgvVendedores.MultiSelect = false;
            dgvVendedores.Name = "dgvVendedores";
            dgvVendedores.ReadOnly = true;
            dgvVendedores.RowHeadersWidth = 62;
            dgvVendedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVendedores.Size = new Size(907, 468);
            dgvVendedores.TabIndex = 16;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(158, 188);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(245, 31);
            txtDni.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 194);
            label4.Name = "label4";
            label4.Size = new Size(43, 25);
            label4.TabIndex = 17;
            label4.Text = "Dni:";
            // 
            // frmVendedor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1415, 644);
            Controls.Add(btnCambiarEstado);
            Controls.Add(btnModificar);
            Controls.Add(label7);
            Controls.Add(dgvVendedores);
            Controls.Add(groupBox1);
            Name = "frmVendedor";
            Text = "Vendedores";
            Load += frmVendedor_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private Button btnGuardar;
        private Button btnCambiarEstado;
        private Button btnModificar;
        private Label label7;
        private DataGridView dgvVendedores;
        private ComboBox cmbSucursales;
        private Label label3;
        private TextBox txtDni;
        private Label label4;
    }
}