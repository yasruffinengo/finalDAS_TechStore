namespace Vista
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void sucursaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSucursal frm = new frmSucursal();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void categoriasProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoria frm = new frmCategoria();
            frm.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente();
            frm.ShowDialog();
        }

        private void vendedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVendedor frm = new frmVendedor();
            frm.ShowDialog();
        }

        private void metodosDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMetodoPago frm = new frmMetodoPago();
            frm.ShowDialog();
        }

        private void descuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDescuento frm = new frmDescuento();
            frm.ShowDialog();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProducto frm = new frmProducto();
            frm.ShowDialog();
        }

        private void btbConsultarInventario_Click(object sender, EventArgs e)
        {
            frmInventario frm = new frmInventario();
            frm.ShowDialog();
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            frmVenta frm = new frmVenta();
            frm.ShowDialog();
        }
    }
}
