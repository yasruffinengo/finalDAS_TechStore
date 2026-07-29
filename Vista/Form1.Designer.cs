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
            btbConsultarInventario = new Button();
            btnFacturas = new Button();
            btnProductos = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnNuevaVenta
            // 
            btnNuevaVenta.Location = new Point(254, 113);
            btnNuevaVenta.Name = "btnNuevaVenta";
            btnNuevaVenta.Size = new Size(254, 70);
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
            menuStrip1.Size = new Size(795, 33);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // configuracionesToolStripMenuItem
            // 
            configuracionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoriasProductosToolStripMenuItem, descuentosToolStripMenuItem, metodosDePagoToolStripMenuItem, sucursaleToolStripMenuItem });
            configuracionesToolStripMenuItem.Name = "configuracionesToolStripMenuItem";
            configuracionesToolStripMenuItem.Size = new Size(153, 29);
            configuracionesToolStripMenuItem.Text = "configuraciones";
            // 
            // categoriasProductosToolStripMenuItem
            // 
            categoriasProductosToolStripMenuItem.Name = "categoriasProductosToolStripMenuItem";
            categoriasProductosToolStripMenuItem.Size = new Size(282, 34);
            categoriasProductosToolStripMenuItem.Text = "categorias productos";
            categoriasProductosToolStripMenuItem.Click += categoriasProductosToolStripMenuItem_Click;
            // 
            // descuentosToolStripMenuItem
            // 
            descuentosToolStripMenuItem.Name = "descuentosToolStripMenuItem";
            descuentosToolStripMenuItem.Size = new Size(282, 34);
            descuentosToolStripMenuItem.Text = "descuentos";
            descuentosToolStripMenuItem.Click += descuentosToolStripMenuItem_Click;
            // 
            // metodosDePagoToolStripMenuItem
            // 
            metodosDePagoToolStripMenuItem.Name = "metodosDePagoToolStripMenuItem";
            metodosDePagoToolStripMenuItem.Size = new Size(282, 34);
            metodosDePagoToolStripMenuItem.Text = "metodos de pago";
            metodosDePagoToolStripMenuItem.Click += metodosDePagoToolStripMenuItem_Click;
            // 
            // sucursaleToolStripMenuItem
            // 
            sucursaleToolStripMenuItem.Name = "sucursaleToolStripMenuItem";
            sucursaleToolStripMenuItem.Size = new Size(282, 34);
            sucursaleToolStripMenuItem.Text = "sucursales";
            sucursaleToolStripMenuItem.Click += sucursaleToolStripMenuItem_Click;
            // 
            // registrarToolStripMenuItem
            // 
            registrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vendedorToolStripMenuItem, vendedorToolStripMenuItem1 });
            registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            registrarToolStripMenuItem.Size = new Size(93, 29);
            registrarToolStripMenuItem.Text = "registrar";
            // 
            // vendedorToolStripMenuItem
            // 
            vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            vendedorToolStripMenuItem.Size = new Size(190, 34);
            vendedorToolStripMenuItem.Text = "cliente";
            vendedorToolStripMenuItem.Click += vendedorToolStripMenuItem_Click;
            // 
            // vendedorToolStripMenuItem1
            // 
            vendedorToolStripMenuItem1.Name = "vendedorToolStripMenuItem1";
            vendedorToolStripMenuItem1.Size = new Size(190, 34);
            vendedorToolStripMenuItem1.Text = "vendedor";
            vendedorToolStripMenuItem1.Click += vendedorToolStripMenuItem1_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(94, 29);
            reportesToolStripMenuItem.Text = "reportes";
            reportesToolStripMenuItem.Click += reportesToolStripMenuItem_Click;
            // 
            // btbConsultarInventario
            // 
            btbConsultarInventario.Location = new Point(254, 312);
            btbConsultarInventario.Name = "btbConsultarInventario";
            btbConsultarInventario.Size = new Size(254, 70);
            btbConsultarInventario.TabIndex = 5;
            btbConsultarInventario.Text = "Inventario";
            btbConsultarInventario.UseVisualStyleBackColor = true;
            btbConsultarInventario.Click += btbConsultarInventario_Click;
            // 
            // btnFacturas
            // 
            btnFacturas.Location = new Point(254, 414);
            btnFacturas.Name = "btnFacturas";
            btnFacturas.Size = new Size(254, 70);
            btnFacturas.TabIndex = 6;
            btnFacturas.Text = "Facturas";
            btnFacturas.UseVisualStyleBackColor = true;
            btnFacturas.Click += button3_Click;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(254, 210);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(254, 70);
            btnProductos.TabIndex = 7;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 546);
            Controls.Add(btnProductos);
            Controls.Add(btnFacturas);
            Controls.Add(btbConsultarInventario);
            Controls.Add(btnNuevaVenta);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmInicio";
            Text = "INICIO";
            Load += frmInicio_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}
