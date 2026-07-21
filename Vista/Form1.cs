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
    }
}
