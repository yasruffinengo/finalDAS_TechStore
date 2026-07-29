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
            btnQuitar = new Button();
            btnVaciar = new Button();
            groupBox3 = new GroupBox();
            label2 = new Label();
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
            dgvDetalleVenta.Location = new Point(16, 251);
            dgvDetalleVenta.Margin = new Padding(2);
            dgvDetalleVenta.MultiSelect = false;
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.ReadOnly = true;
            dgvDetalleVenta.RowHeadersWidth = 62;
            dgvDetalleVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalleVenta.Size = new Size(922, 127);
            dgvDetalleVenta.TabIndex = 2;
            // 
            // lblNumeroVenta
            // 
            lblNumeroVenta.AutoSize = true;
            lblNumeroVenta.Location = new Point(16, 31);
            lblNumeroVenta.Margin = new Padding(2, 0, 2, 0);
            lblNumeroVenta.Name = "lblNumeroVenta";
            lblNumeroVenta.Size = new Size(38, 15);
            lblNumeroVenta.TabIndex = 3;
            lblNumeroVenta.Text = "label1";
            // 
            // dtpFechaVenta
            // 
            dtpFechaVenta.Enabled = false;
            dtpFechaVenta.Location = new Point(369, 31);
            dtpFechaVenta.Margin = new Padding(2);
            dtpFechaVenta.Name = "dtpFechaVenta";
            dtpFechaVenta.Size = new Size(211, 23);
            dtpFechaVenta.TabIndex = 4;
            // 
            // cmbSucursal
            // 
            cmbSucursal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSucursal.FormattingEnabled = true;
            cmbSucursal.Location = new Point(16, 95);
            cmbSucursal.Margin = new Padding(2);
            cmbSucursal.Name = "cmbSucursal";
            cmbSucursal.Size = new Size(167, 23);
            cmbSucursal.TabIndex = 22;
            cmbSucursal.SelectedIndexChanged += cmbSucursal_SelectedIndexChanged;
            // 
            // cmbCliente
            // 
            cmbCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCliente.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(16, 154);
            cmbCliente.Margin = new Padding(2);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(167, 23);
            cmbCliente.TabIndex = 23;
            cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;
            cmbCliente.TextUpdate += cmbCliente_TextUpdate;
            // 
            // cmbVendedor
            // 
            cmbVendedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVendedor.FormattingEnabled = true;
            cmbVendedor.Location = new Point(195, 95);
            cmbVendedor.Margin = new Padding(2);
            cmbVendedor.Name = "cmbVendedor";
            cmbVendedor.Size = new Size(167, 23);
            cmbVendedor.TabIndex = 24;
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Location = new Point(378, 95);
            cmbMetodoPago.Margin = new Padding(2);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(202, 23);
            cmbMetodoPago.TabIndex = 25;
            // 
            // cmbDescuento
            // 
            cmbDescuento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDescuento.FormattingEnabled = true;
            cmbDescuento.Location = new Point(195, 154);
            cmbDescuento.Margin = new Padding(2);
            cmbDescuento.Name = "cmbDescuento";
            cmbDescuento.Size = new Size(159, 23);
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
            groupBox1.Location = new Point(18, 17);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(593, 205);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la venta";
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(16, 131);
            lblNombreCliente.Margin = new Padding(2, 0, 2, 0);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(55, 15);
            lblNombreCliente.TabIndex = 36;
            lblNombreCliente.Text = "Cliente: -";
            lblNombreCliente.Click += lblNombreCliente_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(378, 78);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 35;
            label6.Text = "Método de pago:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(195, 78);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 30;
            label4.Text = "Vendedor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(195, 131);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 34;
            label5.Text = "Descuento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 78);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
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
            groupBox2.Location = new Point(627, 24);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(313, 198);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Agregar productos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 58);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 34;
            label8.Text = "Unidades:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 30);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 34;
            label7.Text = "Producto:";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(10, 147);
            btnAgregarProducto.Margin = new Padding(2);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(294, 33);
            btnAgregarProducto.TabIndex = 5;
            btnAgregarProducto.Text = "Agregar producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // nudUnidades
            // 
            nudUnidades.Location = new Point(95, 52);
            nudUnidades.Margin = new Padding(2);
            nudUnidades.Name = "nudUnidades";
            nudUnidades.Size = new Size(209, 23);
            nudUnidades.TabIndex = 4;
            // 
            // lblStockDisponible
            // 
            lblStockDisponible.AutoSize = true;
            lblStockDisponible.Location = new Point(256, 84);
            lblStockDisponible.Margin = new Padding(2, 0, 2, 0);
            lblStockDisponible.Name = "lblStockDisponible";
            lblStockDisponible.Size = new Size(48, 15);
            lblStockDisponible.TabIndex = 3;
            lblStockDisponible.Text = "Stock: 0";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(10, 84);
            lblPrecio.Margin = new Padding(2, 0, 2, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(52, 15);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio: $";
            // 
            // cmbProducto
            // 
            cmbProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbProducto.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(95, 25);
            cmbProducto.Margin = new Padding(2);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(209, 23);
            cmbProducto.TabIndex = 0;
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(13, 16);
            lblSubtotal.Margin = new Padding(2, 0, 2, 0);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(84, 15);
            lblSubtotal.TabIndex = 29;
            lblSubtotal.Text = "Subtotal: $0,00";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(13, 38);
            lblDescuento.Margin = new Padding(2, 0, 2, 0);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(96, 15);
            lblDescuento.TabIndex = 30;
            lblDescuento.Text = "Descuento: $0,00";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(13, 61);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(66, 15);
            lblTotal.TabIndex = 31;
            lblTotal.Text = "Total: $0,00";
            // 
            // btnGuardarVenta
            // 
            btnGuardarVenta.Location = new Point(834, 489);
            btnGuardarVenta.Margin = new Padding(2);
            btnGuardarVenta.Name = "btnGuardarVenta";
            btnGuardarVenta.Size = new Size(104, 37);
            btnGuardarVenta.TabIndex = 32;
            btnGuardarVenta.Text = "Guardar venta";
            btnGuardarVenta.UseVisualStyleBackColor = true;
            btnGuardarVenta.Click += btnGuardarVenta_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(16, 390);
            btnQuitar.Margin = new Padding(2);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(102, 37);
            btnQuitar.TabIndex = 34;
            btnQuitar.Text = "Quitar producto";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnVaciar
            // 
            btnVaciar.Location = new Point(122, 390);
            btnVaciar.Margin = new Padding(2);
            btnVaciar.Name = "btnVaciar";
            btnVaciar.Size = new Size(94, 37);
            btnVaciar.TabIndex = 35;
            btnVaciar.Text = "Vaciar carrito";
            btnVaciar.UseVisualStyleBackColor = true;
            btnVaciar.Click += btnVaciar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblSubtotal);
            groupBox3.Controls.Add(lblDescuento);
            groupBox3.Controls.Add(lblTotal);
            groupBox3.Location = new Point(756, 390);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(182, 83);
            groupBox3.TabIndex = 36;
            groupBox3.TabStop = false;
            groupBox3.Enter += groupBox3_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 234);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 37;
            label2.Text = "Detalle Venta";
            // 
            // frmVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 539);
            Controls.Add(label2);
            Controls.Add(dgvDetalleVenta);
            Controls.Add(groupBox3);
            Controls.Add(btnVaciar);
            Controls.Add(btnQuitar);
            Controls.Add(btnGuardarVenta);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
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
            PerformLayout();
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
        private Label label2;
    }
}