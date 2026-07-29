namespace Vista
{
    partial class frmReporteVenta
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
            label1 = new Label();
            label2 = new Label();
            cmbFiltrarProducto = new ComboBox();
            cmbFiltrarSucursal = new ComboBox();
            label3 = new Label();
            cmbFiltrarVendedor = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            dtpPeriodoDesde = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            dtpPeriodoHasta = new DateTimePicker();
            dgvReportesVentas = new DataGridView();
            btnSolicitarReporte = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReportesVentas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(18, 20);
            label1.Name = "label1";
            label1.Size = new Size(122, 21);
            label1.TabIndex = 0;
            label1.Text = "Reportes Ventas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F);
            label2.Location = new Point(22, 50);
            label2.Name = "label2";
            label2.Size = new Size(95, 13);
            label2.TabIndex = 1;
            label2.Text = "Filtrar por producto";
            // 
            // cmbFiltrarProducto
            // 
            cmbFiltrarProducto.FormattingEnabled = true;
            cmbFiltrarProducto.Location = new Point(22, 64);
            cmbFiltrarProducto.Margin = new Padding(3, 2, 3, 2);
            cmbFiltrarProducto.Name = "cmbFiltrarProducto";
            cmbFiltrarProducto.Size = new Size(200, 23);
            cmbFiltrarProducto.TabIndex = 5;
            // 
            // cmbFiltrarSucursal
            // 
            cmbFiltrarSucursal.FormattingEnabled = true;
            cmbFiltrarSucursal.Location = new Point(22, 110);
            cmbFiltrarSucursal.Margin = new Padding(3, 2, 3, 2);
            cmbFiltrarSucursal.Name = "cmbFiltrarSucursal";
            cmbFiltrarSucursal.Size = new Size(200, 23);
            cmbFiltrarSucursal.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F);
            label3.Location = new Point(22, 95);
            label3.Name = "label3";
            label3.Size = new Size(92, 13);
            label3.TabIndex = 6;
            label3.Text = "Filtrar por sucursal";
            // 
            // cmbFiltrarVendedor
            // 
            cmbFiltrarVendedor.FormattingEnabled = true;
            cmbFiltrarVendedor.Location = new Point(22, 160);
            cmbFiltrarVendedor.Margin = new Padding(3, 2, 3, 2);
            cmbFiltrarVendedor.Name = "cmbFiltrarVendedor";
            cmbFiltrarVendedor.Size = new Size(200, 23);
            cmbFiltrarVendedor.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F);
            label4.Location = new Point(22, 145);
            label4.Name = "label4";
            label4.Size = new Size(98, 13);
            label4.TabIndex = 8;
            label4.Text = "Filtrar por vendedor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F);
            label5.Location = new Point(22, 197);
            label5.Name = "label5";
            label5.Size = new Size(88, 13);
            label5.TabIndex = 10;
            label5.Text = "Filtrar por periodo";
            // 
            // dtpPeriodoDesde
            // 
            dtpPeriodoDesde.Location = new Point(74, 219);
            dtpPeriodoDesde.Margin = new Padding(3, 2, 3, 2);
            dtpPeriodoDesde.Name = "dtpPeriodoDesde";
            dtpPeriodoDesde.Size = new Size(148, 23);
            dtpPeriodoDesde.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F);
            label6.Location = new Point(25, 224);
            label6.Name = "label6";
            label6.Size = new Size(38, 13);
            label6.TabIndex = 12;
            label6.Text = "Desde";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F);
            label7.Location = new Point(29, 249);
            label7.Name = "label7";
            label7.Size = new Size(35, 13);
            label7.TabIndex = 14;
            label7.Text = "Hasta";
            // 
            // dtpPeriodoHasta
            // 
            dtpPeriodoHasta.Location = new Point(74, 244);
            dtpPeriodoHasta.Margin = new Padding(3, 2, 3, 2);
            dtpPeriodoHasta.Name = "dtpPeriodoHasta";
            dtpPeriodoHasta.Size = new Size(148, 23);
            dtpPeriodoHasta.TabIndex = 13;
            // 
            // dgvReportesVentas
            // 
            dgvReportesVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportesVentas.Location = new Point(262, 16);
            dgvReportesVentas.Margin = new Padding(3, 2, 3, 2);
            dgvReportesVentas.Name = "dgvReportesVentas";
            dgvReportesVentas.RowHeadersWidth = 51;
            dgvReportesVentas.Size = new Size(620, 301);
            dgvReportesVentas.TabIndex = 15;
            // 
            // btnSolicitarReporte
            // 
            btnSolicitarReporte.Location = new Point(108, 295);
            btnSolicitarReporte.Margin = new Padding(3, 2, 3, 2);
            btnSolicitarReporte.Name = "btnSolicitarReporte";
            btnSolicitarReporte.Size = new Size(118, 22);
            btnSolicitarReporte.TabIndex = 16;
            btnSolicitarReporte.Text = "Solicitar reporte";
            btnSolicitarReporte.UseVisualStyleBackColor = true;
            btnSolicitarReporte.Click += btnSolicitarReporte_Click;
            // 
            // frmReporteVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 338);
            Controls.Add(btnSolicitarReporte);
            Controls.Add(dgvReportesVentas);
            Controls.Add(label7);
            Controls.Add(dtpPeriodoHasta);
            Controls.Add(label6);
            Controls.Add(dtpPeriodoDesde);
            Controls.Add(label5);
            Controls.Add(cmbFiltrarVendedor);
            Controls.Add(label4);
            Controls.Add(cmbFiltrarSucursal);
            Controls.Add(label3);
            Controls.Add(cmbFiltrarProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmReporteVenta";
            Text = "frmReporteVenta";
            Load += frmReporteVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReportesVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbFiltrarProducto;
        private ComboBox cmbFiltrarSucursal;
        private Label label3;
        private ComboBox cmbFiltrarVendedor;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpPeriodoDesde;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpPeriodoHasta;
        private DataGridView dgvReportesVentas;
        private Button btnSolicitarReporte;
    }
}
