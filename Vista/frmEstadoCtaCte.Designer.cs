namespace Vista
{
    partial class frmEstadoCtaCte
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            cmbCliente = new ComboBox();
            lblTitulo = new Label();
            lblCliente = new Label();
            lblResumen = new Label();
            lblMovimientos = new Label();
            dgvResumen = new DataGridView();
            dgvDetalle = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResumen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // cmbCliente
            // 
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(171, 55);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(260, 23);
            cmbCliente.TabIndex = 0;
            cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F);
            lblTitulo.Location = new Point(28, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(317, 21);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Estado de Cuentas Corrientes de los Clientes";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 10F);
            lblCliente.Location = new Point(33, 56);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(119, 19);
            lblCliente.TabIndex = 2;
            lblCliente.Text = "Seleccionar cliente";
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblResumen.Location = new Point(33, 94);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(72, 19);
            lblResumen.TabIndex = 3;
            lblResumen.Text = "Resumen";
            // 
            // lblMovimientos
            // 
            lblMovimientos.AutoSize = true;
            lblMovimientos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMovimientos.Location = new Point(33, 284);
            lblMovimientos.Name = "lblMovimientos";
            lblMovimientos.Size = new Size(95, 19);
            lblMovimientos.TabIndex = 4;
            lblMovimientos.Text = "Movimientos";
            //
            // dgvResumen
            //
            dgvResumen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResumen.Location = new Point(33, 116);
            dgvResumen.Name = "dgvResumen";
            dgvResumen.RowHeadersWidth = 51;
            dgvResumen.Size = new Size(820, 150);
            dgvResumen.TabIndex = 5;
            //
            // dgvDetalle
            //
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(33, 306);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.RowHeadersWidth = 51;
            dgvDetalle.Size = new Size(820, 235);
            dgvDetalle.TabIndex = 6;
            // 
            // frmEstadoCtaCte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 565);
            Controls.Add(dgvDetalle);
            Controls.Add(dgvResumen);
            Controls.Add(lblMovimientos);
            Controls.Add(lblResumen);
            Controls.Add(lblCliente);
            Controls.Add(lblTitulo);
            Controls.Add(cmbCliente);
            Name = "frmEstadoCtaCte";
            Text = "Estado de cuentas corrientes";
            Load += frmEstadoCtaCte_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResumen).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCliente;
        private Label lblTitulo;
        private Label lblCliente;
        private Label lblResumen;
        private Label lblMovimientos;
        private DataGridView dgvResumen;
        private DataGridView dgvDetalle;
    }
}
