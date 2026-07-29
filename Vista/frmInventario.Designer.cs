
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
            btn_limpiarFiltros = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvInventario
            // 
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(19, 79);
            dgvInventario.Margin = new Padding(2);
            dgvInventario.MultiSelect = false;
            dgvInventario.Name = "dgvInventario";
            dgvInventario.ReadOnly = true;
            dgvInventario.RowHeadersWidth = 62;
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.Size = new Size(530, 334);
            dgvInventario.TabIndex = 1;
            dgvInventario.CellClick += dgvInventario_CellClick;
            // 
            // label7
            // 
            label7.AccessibleRole = AccessibleRole.Sound;
            label7.AllowDrop = true;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.Location = new Point(19, 20);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(200, 25);
            label7.TabIndex = 12;
            label7.Text = "STOCK DE PRODUCTOS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(567, 79);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
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
            groupBox1.Location = new Point(563, 95);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(302, 226);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // btnAgregarStock
            // 
            btnAgregarStock.Location = new Point(169, 164);
            btnAgregarStock.Margin = new Padding(2);
            btnAgregarStock.Name = "btnAgregarStock";
            btnAgregarStock.Size = new Size(99, 38);
            btnAgregarStock.TabIndex = 35;
            btnAgregarStock.Text = "Agregar stock";
            btnAgregarStock.UseVisualStyleBackColor = true;
            btnAgregarStock.Click += btnAgregarStock_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(110, 97);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(19, 15);
            lblNombre.TabIndex = 34;
            lblNombre.Text = "    ";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(110, 64);
            lblCodigo.Margin = new Padding(2, 0, 2, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(16, 15);
            lblCodigo.TabIndex = 33;
            lblCodigo.Text = "   ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 97);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 32;
            label9.Text = "Nombre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 64);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 31;
            label6.Text = "Codigo:";
            // 
            // cmbSucursal
            // 
            cmbSucursal.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSucursal.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbSucursal.FormattingEnabled = true;
            cmbSucursal.Location = new Point(110, 128);
            cmbSucursal.Margin = new Padding(2);
            cmbSucursal.Name = "cmbSucursal";
            cmbSucursal.Size = new Size(159, 23);
            cmbSucursal.TabIndex = 30;
            // 
            // cmbProducto
            // 
            cmbProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbProducto.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(110, 26);
            cmbProducto.Margin = new Padding(2);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(159, 23);
            cmbProducto.TabIndex = 29;
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 132);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 20;
            label5.Text = "Sucursal:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 32);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 18;
            label8.Text = "Producto:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(947, 498);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(153, 40);
            btnGuardar.TabIndex = 24;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbSucursalFiltro
            // 
            cmbSucursalFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSucursalFiltro.FormattingEnabled = true;
            cmbSucursalFiltro.Location = new Point(77, 49);
            cmbSucursalFiltro.Margin = new Padding(2);
            cmbSucursalFiltro.Name = "cmbSucursalFiltro";
            cmbSucursalFiltro.Size = new Size(159, 23);
            cmbSucursalFiltro.TabIndex = 21;
            cmbSucursalFiltro.SelectionChangeCommitted += cmbSucursalFiltro_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 53);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 20;
            label1.Text = "Sucursal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 52);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 22;
            label2.Text = "Producto:";
            // 
            // txtProductoFiltro
            // 
            txtProductoFiltro.Location = new Point(303, 49);
            txtProductoFiltro.Margin = new Padding(2);
            txtProductoFiltro.Name = "txtProductoFiltro";
            txtProductoFiltro.Size = new Size(159, 23);
            txtProductoFiltro.TabIndex = 23;
            // 
            // btn_limpiarFiltros
            // 
            btn_limpiarFiltros.Location = new Point(466, 49);
            btn_limpiarFiltros.Margin = new Padding(2);
            btn_limpiarFiltros.Name = "btn_limpiarFiltros";
            btn_limpiarFiltros.Size = new Size(83, 23);
            btn_limpiarFiltros.TabIndex = 36;
            btn_limpiarFiltros.Text = "Limpiar";
            btn_limpiarFiltros.UseVisualStyleBackColor = true;
            btn_limpiarFiltros.Click += btn_limpiarFiltros_Click;
            // 
            // frmInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 442);
            Controls.Add(btn_limpiarFiltros);
            Controls.Add(txtProductoFiltro);
            Controls.Add(label2);
            Controls.Add(cmbSucursalFiltro);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(btnGuardar);
            Controls.Add(dgvInventario);
            Margin = new Padding(2);
            Name = "frmInventario";
            Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
        private Button btn_limpiarFiltros;
    }
}