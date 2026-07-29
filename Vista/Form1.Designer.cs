
namespace Vista
{
    partial class frmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNuevaVenta = new Button();
            menuStrip1 = new MenuStrip();
            configuracionesToolStripMenuItem = new ToolStripMenuItem();
            categoriasProductosToolStripMenuItem = new ToolStripMenuItem();
            descuentosToolStripMenuItem = new ToolStripMenuItem();
            metodosDePagoToolStripMenuItem = new ToolStripMenuItem();
            sucursaleToolStripMenuItem = new ToolStripMenuItem();
            registrarToolStripMenuItem = new ToolStripMenuItem();
            vendedorToolStripMenuItem = new ToolStripMenuItem();
            vendedorToolStripMenuItem1 = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            productosMásVendidosToolStripMenuItem = new ToolStripMenuItem();
            estadoDeCtaCorrienteDeClientesToolStripMenuItem = new ToolStripMenuItem();
            btbConsultarInventario = new Button();
            btnFacturas = new Button();
            btnProductos = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            btn_Clientes = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnNuevaVenta
            // 
            btnNuevaVenta.Location = new Point(621, 59);
            btnNuevaVenta.Margin = new Padding(2);
            btnNuevaVenta.Name = "btnNuevaVenta";
            btnNuevaVenta.Size = new Size(178, 42);
            btnNuevaVenta.TabIndex = 0;
            btnNuevaVenta.Text = "Nueva Venta";
            btnNuevaVenta.UseVisualStyleBackColor = true;
            btnNuevaVenta.Click += btnNuevaVenta_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { configuracionesToolStripMenuItem, registrarToolStripMenuItem, reportesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 2, 0, 2);
            menuStrip1.Size = new Size(803, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // configuracionesToolStripMenuItem
            // 
            configuracionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoriasProductosToolStripMenuItem, descuentosToolStripMenuItem, metodosDePagoToolStripMenuItem, sucursaleToolStripMenuItem });
            configuracionesToolStripMenuItem.Name = "configuracionesToolStripMenuItem";
            configuracionesToolStripMenuItem.Size = new Size(104, 20);
            configuracionesToolStripMenuItem.Text = "configuraciones";
            // 
            // categoriasProductosToolStripMenuItem
            // 
            categoriasProductosToolStripMenuItem.Name = "categoriasProductosToolStripMenuItem";
            categoriasProductosToolStripMenuItem.Size = new Size(185, 22);
            categoriasProductosToolStripMenuItem.Text = "categorias productos";
            categoriasProductosToolStripMenuItem.Click += categoriasProductosToolStripMenuItem_Click;
            // 
            // descuentosToolStripMenuItem
            // 
            descuentosToolStripMenuItem.Name = "descuentosToolStripMenuItem";
            descuentosToolStripMenuItem.Size = new Size(185, 22);
            descuentosToolStripMenuItem.Text = "descuentos";
            descuentosToolStripMenuItem.Click += descuentosToolStripMenuItem_Click;
            // 
            // metodosDePagoToolStripMenuItem
            // 
            metodosDePagoToolStripMenuItem.Name = "metodosDePagoToolStripMenuItem";
            metodosDePagoToolStripMenuItem.Size = new Size(185, 22);
            metodosDePagoToolStripMenuItem.Text = "metodos de pago";
            metodosDePagoToolStripMenuItem.Click += metodosDePagoToolStripMenuItem_Click;
            // 
            // sucursaleToolStripMenuItem
            // 
            sucursaleToolStripMenuItem.Name = "sucursaleToolStripMenuItem";
            sucursaleToolStripMenuItem.Size = new Size(185, 22);
            sucursaleToolStripMenuItem.Text = "sucursales";
            sucursaleToolStripMenuItem.Click += sucursaleToolStripMenuItem_Click;
            // 
            // registrarToolStripMenuItem
            // 
            registrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vendedorToolStripMenuItem, vendedorToolStripMenuItem1 });
            registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            registrarToolStripMenuItem.Size = new Size(62, 20);
            registrarToolStripMenuItem.Text = "registrar";
            // 
            // vendedorToolStripMenuItem
            // 
            vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            vendedorToolStripMenuItem.Size = new Size(124, 22);
            vendedorToolStripMenuItem.Text = "cliente";
            vendedorToolStripMenuItem.Click += vendedorToolStripMenuItem_Click;
            // 
            // vendedorToolStripMenuItem1
            // 
            vendedorToolStripMenuItem1.Name = "vendedorToolStripMenuItem1";
            vendedorToolStripMenuItem1.Size = new Size(124, 22);
            vendedorToolStripMenuItem1.Text = "vendedor";
            vendedorToolStripMenuItem1.Click += vendedorToolStripMenuItem1_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ventasToolStripMenuItem, productosMásVendidosToolStripMenuItem, estadoDeCtaCorrienteDeClientesToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(62, 20);
            reportesToolStripMenuItem.Text = "reportes";
            reportesToolStripMenuItem.Click += reportesToolStripMenuItem_Click;
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(253, 22);
            ventasToolStripMenuItem.Text = "Ventas";
            ventasToolStripMenuItem.Click += ventasToolStripMenuItem_Click;
            // 
            // productosMásVendidosToolStripMenuItem
            // 
            productosMásVendidosToolStripMenuItem.Name = "productosMásVendidosToolStripMenuItem";
            productosMásVendidosToolStripMenuItem.Size = new Size(253, 22);
            productosMásVendidosToolStripMenuItem.Text = "Productos más vendidos";
            productosMásVendidosToolStripMenuItem.Click += productosMásVendidosToolStripMenuItem_Click;
            // 
            // estadoDeCtaCorrienteDeClientesToolStripMenuItem
            // 
            estadoDeCtaCorrienteDeClientesToolStripMenuItem.Name = "estadoDeCtaCorrienteDeClientesToolStripMenuItem";
            estadoDeCtaCorrienteDeClientesToolStripMenuItem.Size = new Size(253, 22);
            estadoDeCtaCorrienteDeClientesToolStripMenuItem.Text = "Estado de cta corriente de clientes";
            // 
            // btbConsultarInventario
            // 
            btbConsultarInventario.Location = new Point(621, 105);
            btbConsultarInventario.Margin = new Padding(2);
            btbConsultarInventario.Name = "btbConsultarInventario";
            btbConsultarInventario.Size = new Size(178, 42);
            btbConsultarInventario.TabIndex = 5;
            btbConsultarInventario.Text = "Inventario";
            btbConsultarInventario.UseVisualStyleBackColor = true;
            btbConsultarInventario.Click += btbConsultarInventario_Click;
            // 
            // btnFacturas
            // 
            btnFacturas.Location = new Point(621, 196);
            btnFacturas.Margin = new Padding(2);
            btnFacturas.Name = "btnFacturas";
            btnFacturas.Size = new Size(178, 42);
            btnFacturas.TabIndex = 6;
            btnFacturas.Text = "Facturas";
            btnFacturas.UseVisualStyleBackColor = true;
            btnFacturas.Click += button3_Click;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(621, 150);
            btnProductos.Margin = new Padding(2);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(178, 42);
            btnProductos.TabIndex = 7;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(604, 359);
            dataGridView1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 9;
            label1.Text = "Ultimas ventas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(621, 41);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 10;
            label2.Text = "Accesos Rapidos";
            // 
            // btn_Clientes
            // 
            btn_Clientes.Location = new Point(621, 376);
            btn_Clientes.Margin = new Padding(2);
            btn_Clientes.Name = "btn_Clientes";
            btn_Clientes.Size = new Size(178, 42);
            btn_Clientes.TabIndex = 11;
            btn_Clientes.Text = "Clientes";
            btn_Clientes.UseVisualStyleBackColor = true;
            btn_Clientes.Click += btn_Clientes_Click;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 430);
            Controls.Add(btn_Clientes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnProductos);
            Controls.Add(btnFacturas);
            Controls.Add(btbConsultarInventario);
            Controls.Add(btnNuevaVenta);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "frmInicio";
            Text = "INICIO";
            Load += frmInicio_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteVenta frm = new frmReporteVenta();
            frm.ShowDialog();
        }

        private void productosMásVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductoMasVendido frm = new frmProductoMasVendido();
            frm.ShowDialog();
        }

        #endregion

        private Button btnNuevaVenta;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem configuracionesToolStripMenuItem;
        private ToolStripMenuItem categoriasProductosToolStripMenuItem;
        private ToolStripMenuItem descuentosToolStripMenuItem;
        private ToolStripMenuItem metodosDePagoToolStripMenuItem;
        private ToolStripMenuItem sucursaleToolStripMenuItem;
        private ToolStripMenuItem registrarToolStripMenuItem;
        private ToolStripMenuItem vendedorToolStripMenuItem;
        private Button btbConsultarInventario;
        private Button btnFacturas;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem vendedorToolStripMenuItem1;
        private Button btnProductos;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem productosMásVendidosToolStripMenuItem;
        private ToolStripMenuItem estadoDeCtaCorrienteDeClientesToolStripMenuItem;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Button btn_Clientes;
    }
}
