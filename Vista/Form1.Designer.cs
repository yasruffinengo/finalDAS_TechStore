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
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            configuracionesToolStripMenuItem = new ToolStripMenuItem();
            categoriasProductosToolStripMenuItem = new ToolStripMenuItem();
            descuentosToolStripMenuItem = new ToolStripMenuItem();
            metodosDePagoToolStripMenuItem = new ToolStripMenuItem();
            sucursaleToolStripMenuItem = new ToolStripMenuItem();
            registrarToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            vendedorToolStripMenuItem = new ToolStripMenuItem();
            vendedorToolStripMenuItem1 = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            button5 = new Button();
            button3 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(68, 119);
            button1.Name = "button1";
            button1.Size = new Size(254, 70);
            button1.TabIndex = 0;
            button1.Text = "Nueva Venta";
            button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { configuracionesToolStripMenuItem, registrarToolStripMenuItem, reportesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(368, 33);
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
            // 
            // metodosDePagoToolStripMenuItem
            // 
            metodosDePagoToolStripMenuItem.Name = "metodosDePagoToolStripMenuItem";
            metodosDePagoToolStripMenuItem.Size = new Size(282, 34);
            metodosDePagoToolStripMenuItem.Text = "metodos de pago";
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
            registrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, vendedorToolStripMenuItem, vendedorToolStripMenuItem1 });
            registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            registrarToolStripMenuItem.Size = new Size(93, 29);
            registrarToolStripMenuItem.Text = "registrar";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(270, 34);
            clienteToolStripMenuItem.Text = "producto";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // vendedorToolStripMenuItem
            // 
            vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            vendedorToolStripMenuItem.Size = new Size(270, 34);
            vendedorToolStripMenuItem.Text = "cliente";
            vendedorToolStripMenuItem.Click += vendedorToolStripMenuItem_Click;
            // 
            // vendedorToolStripMenuItem1
            // 
            vendedorToolStripMenuItem1.Name = "vendedorToolStripMenuItem1";
            vendedorToolStripMenuItem1.Size = new Size(270, 34);
            vendedorToolStripMenuItem1.Text = "vendedor";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(94, 29);
            reportesToolStripMenuItem.Text = "reportes";
            // 
            // button5
            // 
            button5.Location = new Point(68, 220);
            button5.Name = "button5";
            button5.Size = new Size(254, 70);
            button5.TabIndex = 5;
            button5.Text = "Consultar Inventario";
            button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(68, 327);
            button3.Name = "button3";
            button3.Size = new Size(254, 70);
            button3.TabIndex = 6;
            button3.Text = "Facturas";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 472);
            Controls.Add(button3);
            Controls.Add(button5);
            Controls.Add(button1);
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

        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem configuracionesToolStripMenuItem;
        private ToolStripMenuItem categoriasProductosToolStripMenuItem;
        private ToolStripMenuItem descuentosToolStripMenuItem;
        private ToolStripMenuItem metodosDePagoToolStripMenuItem;
        private ToolStripMenuItem sucursaleToolStripMenuItem;
        private ToolStripMenuItem registrarToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem vendedorToolStripMenuItem;
        private Button button5;
        private Button button3;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem vendedorToolStripMenuItem1;
    }
}
