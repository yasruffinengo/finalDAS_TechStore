namespace Vista
{
    partial class frmDetalleVenta
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            lblVenta = new Label();
            lblCliente = new Label();
            lblTotal = new Label();
            lblSucursal = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(539, 324);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 92);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "Productos";
            // 
            // lblVenta
            // 
            lblVenta.AutoSize = true;
            lblVenta.Font = new Font("Segoe UI", 12F);
            lblVenta.Location = new Point(14, 9);
            lblVenta.Name = "lblVenta";
            lblVenta.Size = new Size(52, 21);
            lblVenta.TabIndex = 2;
            lblVenta.Text = "Venta:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 10F);
            lblCliente.Location = new Point(14, 30);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(54, 19);
            lblCliente.TabIndex = 3;
            lblCliente.Text = "Cliente:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F);
            lblTotal.Location = new Point(381, 46);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(58, 21);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total: $";
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Font = new Font("Segoe UI", 10F);
            lblSucursal.Location = new Point(14, 49);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(62, 19);
            lblSucursal.TabIndex = 5;
            lblSucursal.Text = "Sucursal:";
            // 
            // frmDetalleVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 446);
            Controls.Add(lblSucursal);
            Controls.Add(lblTotal);
            Controls.Add(lblCliente);
            Controls.Add(lblVenta);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "frmDetalleVenta";
            Text = "frmDetalleVenta";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label lblVenta;
        private Label lblCliente;
        private Label lblTotal;
        private Label lblSucursal;
    }
}