namespace Vista
{
    partial class frmProducto
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
            dgvProductos = new DataGridView();
            label6 = new Label();
            groupBox1 = new GroupBox();
            btnGuardar = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtDescripcion = new TextBox();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            cmbCategoria = new ComboBox();
            nudMontoUnitario = new NumericUpDown();
            label3 = new Label();
            btnCambiarEstado = new Button();
            btnModificar = new Button();
            label1 = new Label();
            label2 = new Label();
            cmbBusquedaCategoria = new ComboBox();
            txtBusquedaNombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMontoUnitario).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(10, 116);
            dgvProductos.Margin = new Padding(2);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(815, 383);
            dgvProductos.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(850, 103);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(116, 20);
            label6.TabIndex = 11;
            label6.Text = "Nuevo Producto";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(nudMontoUnitario);
            groupBox1.Location = new Point(850, 126);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(346, 356);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(233, 311);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 27);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 269);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 19;
            label7.Text = "Categoria:";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 209);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 18;
            label8.Text = "Precio:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(42, 152);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(90, 20);
            label9.TabIndex = 17;
            label9.Text = "Descripcion:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(42, 97);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(61, 20);
            label10.TabIndex = 16;
            label10.Text = "Código:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(42, 47);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(67, 20);
            label11.TabIndex = 15;
            label11.Text = "Nombre:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(161, 147);
            txtDescripcion.Margin = new Padding(2);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(162, 27);
            txtDescripcion.TabIndex = 14;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(161, 92);
            txtCodigo.Margin = new Padding(2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(162, 27);
            txtCodigo.TabIndex = 13;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(161, 42);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(162, 27);
            txtNombre.TabIndex = 12;
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(161, 262);
            cmbCategoria.Margin = new Padding(2);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(162, 28);
            cmbCategoria.TabIndex = 11;
            // 
            // nudMontoUnitario
            // 
            nudMontoUnitario.Location = new Point(161, 204);
            nudMontoUnitario.Margin = new Padding(2);
            nudMontoUnitario.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudMontoUnitario.Name = "nudMontoUnitario";
            nudMontoUnitario.Size = new Size(162, 27);
            nudMontoUnitario.TabIndex = 10;
            // 
            // label3
            // 
            label3.AccessibleRole = AccessibleRole.Sound;
            label3.AllowDrop = true;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(10, 27);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(139, 30);
            label3.TabIndex = 13;
            label3.Text = "PRODUCTOS";
            // 
            // btnCambiarEstado
            // 
            btnCambiarEstado.Location = new Point(683, 511);
            btnCambiarEstado.Margin = new Padding(2);
            btnCambiarEstado.Name = "btnCambiarEstado";
            btnCambiarEstado.Size = new Size(142, 27);
            btnCambiarEstado.TabIndex = 17;
            btnCambiarEstado.Text = "Cambiar estado";
            btnCambiarEstado.UseVisualStyleBackColor = true;
            btnCambiarEstado.Click += btnCambiarEstado_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(573, 511);
            btnModificar.Margin = new Padding(2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(90, 27);
            btnModificar.TabIndex = 16;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 82);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 18;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 82);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 19;
            label2.Text = "Categoria:";
            // 
            // cmbBusquedaCategoria
            // 
            cmbBusquedaCategoria.FormattingEnabled = true;
            cmbBusquedaCategoria.Location = new Point(414, 76);
            cmbBusquedaCategoria.Margin = new Padding(2);
            cmbBusquedaCategoria.Name = "cmbBusquedaCategoria";
            cmbBusquedaCategoria.Size = new Size(146, 28);
            cmbBusquedaCategoria.TabIndex = 20;
            cmbBusquedaCategoria.SelectionChangeCommitted += cmbBusquedaCategoria_SelectionChangeCommitted;
            // 
            // txtBusquedaNombre
            // 
            txtBusquedaNombre.Location = new Point(121, 78);
            txtBusquedaNombre.Margin = new Padding(2);
            txtBusquedaNombre.Name = "txtBusquedaNombre";
            txtBusquedaNombre.Size = new Size(149, 27);
            txtBusquedaNombre.TabIndex = 21;
            txtBusquedaNombre.TextChanged += txtBusquedaNombre_TextChanged;
            // 
            // frmProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 548);
            Controls.Add(txtBusquedaNombre);
            Controls.Add(cmbBusquedaCategoria);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCambiarEstado);
            Controls.Add(btnModificar);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(dgvProductos);
            Margin = new Padding(2);
            Name = "frmProducto";
            Text = "Productos";
            Load += frmProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMontoUnitario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvProductos;
        private Label label6;
        private GroupBox groupBox1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtDescripcion;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private ComboBox cmbCategoria;
        private NumericUpDown nudMontoUnitario;
        private Label label3;
        private Button btnGuardar;
        private Button btnCambiarEstado;
        private Button btnModificar;
        private Label label1;
        private Label label2;
        private ComboBox cmbBusquedaCategoria;
        private TextBox txtBusquedaNombre;
    }
}