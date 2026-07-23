namespace Vista
{
    partial class frmMetodoPago
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
            label4 = new Label();
            groupBox1 = new GroupBox();
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnGuardar = new Button();
            txtDescripcion = new TextBox();
            btnModificar = new Button();
            btnCambiarEstado = new Button();
            label3 = new Label();
            dgvMetodosPago = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMetodosPago).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(618, 86);
            label4.Name = "label4";
            label4.Size = new Size(203, 25);
            label4.TabIndex = 11;
            label4.Text = "Nuevo Metodo de Pago";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Location = new Point(618, 114);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(432, 295);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(144, 54);
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
            label2.Location = new Point(24, 133);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 1;
            label2.Text = "Descripcion:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(277, 222);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(144, 133);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(245, 63);
            txtDescripcion.TabIndex = 3;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(273, 521);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 34);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnCambiarEstado
            // 
            btnCambiarEstado.Location = new Point(423, 521);
            btnCambiarEstado.Name = "btnCambiarEstado";
            btnCambiarEstado.Size = new Size(158, 34);
            btnCambiarEstado.TabIndex = 12;
            btnCambiarEstado.Text = "Cambiar estado";
            btnCambiarEstado.UseVisualStyleBackColor = true;
            btnCambiarEstado.Click += btnCambiarEstado_Click;
            // 
            // label3
            // 
            label3.AccessibleRole = AccessibleRole.Sound;
            label3.AllowDrop = true;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(45, 63);
            label3.Name = "label3";
            label3.Size = new Size(248, 36);
            label3.TabIndex = 9;
            label3.Text = "METODOS DE PAGO";
            // 
            // dgvMetodosPago
            // 
            dgvMetodosPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMetodosPago.Location = new Point(45, 114);
            dgvMetodosPago.Name = "dgvMetodosPago";
            dgvMetodosPago.RowHeadersWidth = 62;
            dgvMetodosPago.Size = new Size(536, 377);
            dgvMetodosPago.TabIndex = 10;
            // 
            // frmMetodoPago
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 618);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(btnModificar);
            Controls.Add(btnCambiarEstado);
            Controls.Add(label3);
            Controls.Add(dgvMetodosPago);
            Name = "frmMetodoPago";
            Text = "Metodos de pago";
            Load += frmMetodoPago_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMetodosPago).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private GroupBox groupBox1;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private Button btnGuardar;
        private TextBox txtDescripcion;
        private Button btnModificar;
        private Button btnCambiarEstado;
        private Label label3;
        private DataGridView dgvMetodosPago;
    }
}