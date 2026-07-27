namespace Vista
{
    partial class frmAgregarStock
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
            lblMensaje = new Label();
            nudAgregarStock = new NumericUpDown();
            btnCancelar = new Button();
            btnAceptar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudAgregarStock).BeginInit();
            SuspendLayout();
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(73, 52);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(59, 25);
            lblMensaje.TabIndex = 0;
            lblMensaje.Text = "label1";
            // 
            // nudAgregarStock
            // 
            nudAgregarStock.Location = new Point(73, 106);
            nudAgregarStock.Name = "nudAgregarStock";
            nudAgregarStock.Size = new Size(180, 31);
            nudAgregarStock.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(73, 213);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(331, 103);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(112, 34);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmAgregarStock
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 274);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(nudAgregarStock);
            Controls.Add(lblMensaje);
            Name = "frmAgregarStock";
            Text = "Agregar Stock";
            Load += frmAgregarStock_Load;
            ((System.ComponentModel.ISupportInitialize)nudAgregarStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensaje;
        private NumericUpDown nudAgregarStock;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}