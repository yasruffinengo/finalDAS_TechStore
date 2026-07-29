namespace Vista
{
    partial class frmVenta
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
            dgvDetalleVenta = new DataGridView();
            lblNumeroVenta = new Label();
            dtpFechaVenta = new DateTimePicker();
            cmbSucursal = new ComboBox();
            cmbCliente = new ComboBox();
            cmbVendedor = new ComboBox();
            cmbMetodoPago = new ComboBox();
            cmbDescuento = new ComboBox();
            groupBox1 = new GroupBox();
            lblNombreCliente = new Label();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            btnAgregarProducto = new Button();
            nudUnidades = new NumericUpDown();
            lblStockDisponible = new Label();
            lblPrecio = new Label();
            cmbProducto = new ComboBox();
            lblSubtotal = new Label();
            lblDescuento = new Label();
            lblTotal = new Label();
            btnGuardarVenta = new Button();
            btnGenerarFactura = new Button();
            btnQuitar = new Button();
            btnVaciar = new Button();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudUnidades).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDetalleVenta
            // 
            dgvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleVenta.Location = new Point(26, 468);
            dgvDetalleVenta.MultiSelect = false;
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.ReadOnly = true;
            dgvDetalleVenta.RowHeadersWidth = 62;
            dgvDetalleVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalleVenta.Size = new Size(951, 212);
            dgvDetalleVenta.TabIndex = 2;
            // 
            // lblNumeroVenta
            // 
            lblNumeroVenta.AutoSize = true;
            lblNumeroVenta.Location = new Point(47, 58);
            lblNumeroVenta.Name = "lblNumeroVenta";
            lblNumeroVenta.Size = new Size(59, 25);
            lblNumeroVenta.TabIndex = 3;
            lblNumeroVenta.Text = "label1";
            // 
            // dtpFechaVenta
            // 
            dtpFechaVenta.Enabled = false;
            dtpFechaVenta.Location = new Point(306, 52);
            dtpFechaVenta.Name = "dtpFechaVenta";
            dtpFechaVenta.Size = new Size(300, 31);
            dtpFechaVenta.TabIndex = 4;
            // 
            // cmbSucursal
            // 
            cmbSucursal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSucursal.FormattingEnabled = true;
            cmbSucursal.Location = new Point(691, 55);
            cmbSucursal.Name = "cmbSucursal";
            cmbSucursal.Size = new Size(175, 33);
            cmbSucursal.TabIndex = 22;
            cmbSucursal.SelectedIndexChanged += cmbSucursal_SelectedIndexChanged;
            // 
            // cmbCliente
            // 
            cmbCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCliente.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(47, 159);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(237, 33);
            cmbCliente.TabIndex = 23;
            cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;
            cmbCliente.TextUpdate += cmbCliente_TextUpdate;
            // 
            // cmbVendedor
            // 
            cmbVendedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVendedor.FormattingEnabled = true;
            cmbVendedor.Location = new Point(937, 55);
            cmbVendedor.Name = "cmbVendedor";
            cmbVendedor.Size = new Size(190, 33);
            cmbVendedor.TabIndex = 24;
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Location = new Point(821, 158);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(225, 33);
            cmbMetodoPago.TabIndex = 25;
            // 
            // cmbDescuento
            // 
            cmbDescuento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDescuento.FormattingEnabled = true;
            cmbDescuento.Location = new Point(507, 158);
            cmbDescuento.Name = "cmbDescuento";
            cmbDescuento.Size = new Size(225, 33);
            cmbDescuento.TabIndex = 26;
            cmbDescuento.SelectedIndexChanged += cmbDescuento_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblNombreCliente);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblNumeroVenta);
            groupBox1.Controls.Add(cmbDescuento);
            groupBox1.Controls.Add(cmbMetodoPago);
            groupBox1.Controls.Add(dtpFechaVenta);
            groupBox1.Controls.Add(cmbSucursal);
            groupBox1.Controls.Add(cmbVendedor);
            groupBox1.Controls.Add(cmbCliente);
            groupBox1.Location = new Point(26, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1207, 219);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la venta";
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(47, 119);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(81, 25);
            lblNombreCliente.TabIndex = 36;
            lblNombreCliente.Text = "Cliente: -";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(821, 119);
            label6.Name = "label6";
            label6.Size = new Size(152, 25);
            label6.TabIndex = 35;
            label6.Text = "Método de pago:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(937, 27);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 30;
            label4.Text = "Vendedor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(507, 119);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 34;
            label5.Text = "Descuento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(691, 27);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 27;
            label1.Text = "Sucursal:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(btnAgregarProducto);
            groupBox2.Controls.Add(nudUnidades);
            groupBox2.Controls.Add(lblStockDisponible);
            groupBox2.Controls.Add(lblPrecio);
            groupBox2.Controls.Add(cmbProducto);
            groupBox2.Location = new Point(26, 282);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1207, 180);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Agregar productos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 124);
            label8.Name = "label8";
            label8.Size = new Size(90, 25);
            label8.TabIndex = 34;
            label8.Text = "Unidades:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 50);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 34;
            label7.Text = "Producto:";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(840, 39);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(179, 34);
            btnAgregarProducto.TabIndex = 5;
            btnAgregarProducto.Text = "Agregar producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // nudUnidades
            // 
            nudUnidades.Location = new Point(138, 118);
            nudUnidades.Name = "nudUnidades";
            nudUnidades.Size = new Size(180, 31);
            nudUnidades.TabIndex = 4;
            // 
            // lblStockDisponible
            // 
            lblStockDisponible.AutoSize = true;
            lblStockDisponible.Location = new Point(734, 47);
            lblStockDisponible.Name = "lblStockDisponible";
            lblStockDisponible.Size = new Size(74, 25);
            lblStockDisponible.TabIndex = 3;
            lblStockDisponible.Text = "Stock: 0";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(499, 48);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(79, 25);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio: $";
            // 
            // cmbProducto
            // 
            cmbProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbProducto.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(136, 42);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(297, 33);
            cmbProducto.TabIndex = 0;
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(18, 27);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(132, 25);
            lblSubtotal.TabIndex = 29;
            lblSubtotal.Text = "Subtotal: $0,00";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(18, 64);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(149, 25);
            lblDescuento.TabIndex = 30;
            lblDescuento.Text = "Descuento: $0,00";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(18, 102);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(102, 25);
            lblTotal.TabIndex = 31;
            lblTotal.Text = "Total: $0,00";
            // 
            // btnGuardarVenta
            // 
            btnGuardarVenta.Location = new Point(650, 829);
            btnGuardarVenta.Name = "btnGuardarVenta";
            btnGuardarVenta.Size = new Size(148, 34);
            btnGuardarVenta.TabIndex = 32;
            btnGuardarVenta.Text = "Guardar venta";
            btnGuardarVenta.UseVisualStyleBackColor = true;
            btnGuardarVenta.Click += btnGuardarVenta_Click;
            // 
            // btnGenerarFactura
            // 
            btnGenerarFactura.Location = new Point(832, 829);
            btnGenerarFactura.Name = "btnGenerarFactura";
            btnGenerarFactura.Size = new Size(145, 34);
            btnGenerarFactura.TabIndex = 33;
            btnGenerarFactura.Text = "Generar factura";
            btnGenerarFactura.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(1017, 587);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(112, 34);
            btnQuitar.TabIndex = 34;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnVaciar
            // 
            btnVaciar.Location = new Point(1017, 646);
            btnVaciar.Name = "btnVaciar";
            btnVaciar.Size = new Size(112, 34);
            btnVaciar.TabIndex = 35;
            btnVaciar.Text = "Vaciar";
            btnVaciar.UseVisualStyleBackColor = true;
            btnVaciar.Click += btnVaciar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblSubtotal);
            groupBox3.Controls.Add(lblDescuento);
            groupBox3.Controls.Add(lblTotal);
            groupBox3.Location = new Point(717, 673);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(260, 138);
            groupBox3.TabIndex = 36;
            groupBox3.TabStop = false;
            groupBox3.Enter += groupBox3_Enter;
            // 
            // frmVenta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 891);
            Controls.Add(dgvDetalleVenta);
            Controls.Add(groupBox3);
            Controls.Add(btnVaciar);
            Controls.Add(btnQuitar);
            Controls.Add(btnGenerarFactura);
            Controls.Add(btnGuardarVenta);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmVenta";
            Text = "Venta";
            Load += frmVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudUnidades).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDetalleVenta;
        private Label lblNumeroVenta;
        private DateTimePicker dtpFechaVenta;
        private ComboBox cmbSucursal;
        private ComboBox cmbCliente;
        private ComboBox cmbVendedor;
        private ComboBox cmbMetodoPago;
        private ComboBox cmbDescuento;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox cmbProducto;
        private Button btnAgregarProducto;
        private NumericUpDown nudUnidades;
        private Label lblStockDisponible;
        private Label lblPrecio;
        private Label lblSubtotal;
        private Label lblDescuento;
        private Label lblTotal;
        private Button btnGuardarVenta;
        private Button btnGenerarFactura;
        private Label label1;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label8;
        private Label label7;
        private Button btnQuitar;
        private Button btnVaciar;
        private Label lblNombreCliente;
        private GroupBox groupBox3;
    }
}