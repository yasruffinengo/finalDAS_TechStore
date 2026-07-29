namespace Vista
{
    partial class frmInventario
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
            dgvInventario = new DataGridView();
            label7 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            btnAgregarStock = new Button();
            lblNombre = new Label();
            lblCodigo = new Label();
            label9 = new Label();
            label6 = new Label();
            cmbSucursal = new ComboBox();
            cmbProducto = new ComboBox();
            label5 = new Label();
            label8 = new Label();
            btnGuardar = new Button();
            cmbSucursalFiltro = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtProductoFiltro = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvInventario
            // 
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(27, 131);
            dgvInventario.MultiSelect = false;
            dgvInventario.Name = "dgvInventario";
            dgvInventario.ReadOnly = true;
            dgvInventario.RowHeadersWidth = 62;
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.Size = new Size(728, 556);
            dgvInventario.TabIndex = 1;
            dgvInventario.CellClick += dgvInventario_CellClick;
            // 
            // label7
            // 
            label7.AccessibleRole = AccessibleRole.Sound;
            label7.AllowDrop = true;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.Location = new Point(27, 33);
            label7.Name = "label7";
            label7.Size = new Size(288, 36);
            label7.TabIndex = 12;
            label7.Text = "STOCK DE PRODUCTOS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(810, 131);
            label4.Name = "label4";
            label4.Size = new Size(136, 25);
            label4.TabIndex = 13;
            label4.Text = "Actualizar Stock";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgregarStock);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(lblCodigo);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmbSucursal);
            groupBox1.Controls.Add(cmbProducto);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(804, 159);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(431, 377);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnAgregarStock
            // 
            btnAgregarStock.Location = new Point(241, 272);
            btnAgregarStock.Name = "btnAgregarStock";
            btnAgregarStock.Size = new Size(141, 62);
            btnAgregarStock.TabIndex = 35;
            btnAgregarStock.Text = "Agregar stock";
            btnAgregarStock.UseVisualStyleBackColor = true;
            btnAgregarStock.Click += btnAgregarStock_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(157, 161);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(32, 25);
            lblNombre.TabIndex = 34;
            lblNombre.Text = "    ";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(157, 107);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(27, 25);
            lblCodigo.TabIndex = 33;
            lblCodigo.Text = "   ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 161);
            label9.Name = "label9";
            label9.Size = new Size(82, 25);
            label9.TabIndex = 32;
            label9.Text = "Nombre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 107);
            label6.Name = "label6";
            label6.Size = new Size(75, 25);
            label6.TabIndex = 31;
            label6.Text = "Codigo:";
            // 
            // cmbSucursal
            // 
            cmbSucursal.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSucursal.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbSucursal.FormattingEnabled = true;
            cmbSucursal.Location = new Point(157, 212);
            cmbSucursal.Name = "cmbSucursal";
            cmbSucursal.Size = new Size(225, 33);
            cmbSucursal.TabIndex = 30;
            cmbSucursal.SelectedIndexChanged += cmbSucursal_SelectedIndexChanged;
            // 
            // cmbProducto
            // 
            cmbProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbProducto.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(157, 44);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(225, 33);
            cmbProducto.TabIndex = 29;
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 220);
            label5.Name = "label5";
            label5.Size = new Size(81, 25);
            label5.TabIndex = 20;
            label5.Text = "Sucursal:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 52);
            label8.Name = "label8";
            label8.Size = new Size(89, 25);
            label8.TabIndex = 18;
            label8.Text = "Producto:";
            label8.Click += label8_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(1082, 664);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(175, 54);
            btnGuardar.TabIndex = 24;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbSucursalFiltro
            // 
            cmbSucursalFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSucursalFiltro.FormattingEnabled = true;
            cmbSucursalFiltro.Location = new Point(125, 81);
            cmbSucursalFiltro.Name = "cmbSucursalFiltro";
            cmbSucursalFiltro.Size = new Size(225, 33);
            cmbSucursalFiltro.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 89);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 20;
            label1.Text = "Sucursal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(394, 89);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 22;
            label2.Text = "Producto:";
            // 
            // txtProductoFiltro
            // 
            txtProductoFiltro.Location = new Point(504, 81);
            txtProductoFiltro.Name = "txtProductoFiltro";
            txtProductoFiltro.Size = new Size(225, 31);
            txtProductoFiltro.TabIndex = 23;
            // 
            // frmInventario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 701);
            Controls.Add(txtProductoFiltro);
            Controls.Add(label2);
            Controls.Add(cmbSucursalFiltro);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(btnGuardar);
            Controls.Add(dgvInventario);
            Name = "frmInventario";
            Text = "Inventario";
            Load += frmInventario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvInventario;
        private Label label7;
        private Label label4;
        private GroupBox groupBox1;
        private Label label8;
        private Label label5;
        private ComboBox cmbSucursalFiltro;
        private Label label1;
        private Label label2;
        private TextBox txtProductoFiltro;
        private Button btnGuardar;
        private ComboBox cmbSucursal;
        private ComboBox cmbProducto;
        private Label label9;
        private Label label6;
        private Label lblNombre;
        private Label lblCodigo;
        private Button btnAgregarStock;
    }
}