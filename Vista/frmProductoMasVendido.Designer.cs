namespace Vista
{
    partial class frmProductoMasVendido
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
            lblProductosMasVendidos = new Label();
            dgvProductosMasVendidos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProductosMasVendidos).BeginInit();
            SuspendLayout();
            // 
            // lblProductosMasVendidos
            // 
            lblProductosMasVendidos.AutoSize = true;
            lblProductosMasVendidos.Font = new Font("Segoe UI", 12F);
            lblProductosMasVendidos.Location = new Point(24, 20);
            lblProductosMasVendidos.Name = "lblProductosMasVendidos";
            lblProductosMasVendidos.Size = new Size(226, 28);
            lblProductosMasVendidos.TabIndex = 0;
            lblProductosMasVendidos.Text = "Productos mas vendidos";
            // 
            // dgvProductosMasVendidos
            // 
            dgvProductosMasVendidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosMasVendidos.Location = new Point(24, 61);
            dgvProductosMasVendidos.Name = "dgvProductosMasVendidos";
            dgvProductosMasVendidos.RowHeadersWidth = 51;
            dgvProductosMasVendidos.Size = new Size(764, 358);
            dgvProductosMasVendidos.TabIndex = 1;
            // 
            // frmProductoMasVendido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 436);
            Controls.Add(dgvProductosMasVendidos);
            Controls.Add(lblProductosMasVendidos);
            Name = "frmProductoMasVendido";
            Text = "frmProductoMasVendido";
            Load += frmProductoMasVendido_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductosMasVendidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductosMasVendidos;
        private DataGridView dgvProductosMasVendidos;
    }
}
