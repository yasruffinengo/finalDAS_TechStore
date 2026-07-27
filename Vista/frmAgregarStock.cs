using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmAgregarStock : Form
    {
        public int CantidadIngresada { get; private set; }
        public frmAgregarStock(string nombreProducto)
        {
            InitializeComponent();
            lblMensaje.Text =
                $"¿Cuántas unidades de {nombreProducto} ingresaron?";

            nudAgregarStock.Minimum = 1;
            nudAgregarStock.Maximum = 1000000;
            nudAgregarStock.Value = 1;

            CantidadIngresada = 0;
        }

        private void frmAgregarStock_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CantidadIngresada = (int)nudAgregarStock.Value;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
