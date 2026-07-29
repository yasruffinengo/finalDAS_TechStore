using Controladora;
using Entidades.DTOs;

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
            RefrescarGrillaUltimasVentas();
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
            RefrescarGrillaUltimasVentas();
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente();
            frm.ShowDialog();
        }

        private void btn_vendedores_Click(object sender, EventArgs e)
        {
            frmVendedor frm = new frmVendedor();
            frm.ShowDialog();
        }

        private void RefrescarGrillaUltimasVentas()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ControladoraVenta.Instancia
                    .ListarVentasResumen()
                    .ToList();

                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridView1.MultiSelect = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dataGridView1.Columns["VentaId"] != null)
                    dataGridView1.Columns["VentaId"].Visible = false;

                if (dataGridView1.Columns["NumeroVenta"] != null)
                    dataGridView1.Columns["NumeroVenta"].HeaderText = "Nro. Venta";

                if (dataGridView1.Columns["FechaVenta"] != null)
                {
                    dataGridView1.Columns["FechaVenta"].HeaderText = "Fecha";
                    dataGridView1.Columns["FechaVenta"].DefaultCellStyle.Format = "g";
                }

                if (dataGridView1.Columns["MetodoPago"] != null)
                    dataGridView1.Columns["MetodoPago"].HeaderText = "Metodo de pago";

                if (dataGridView1.Columns["MontoSubtotal"] != null)
                {
                    dataGridView1.Columns["MontoSubtotal"].HeaderText = "Subtotal";
                    dataGridView1.Columns["MontoSubtotal"].DefaultCellStyle.Format = "C2";
                }

                if (dataGridView1.Columns["MontoDescuento"] != null)
                {
                    dataGridView1.Columns["MontoDescuento"].HeaderText = "Descuento";
                    dataGridView1.Columns["MontoDescuento"].DefaultCellStyle.Format = "C2";
                }

                if (dataGridView1.Columns["MontoTotal"] != null)
                {
                    dataGridView1.Columns["MontoTotal"].HeaderText = "Total";
                    dataGridView1.Columns["MontoTotal"].DefaultCellStyle.Format = "C2";
                }

                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al cargar ventas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnVerDetalleVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null ||
                    dataGridView1.CurrentRow.DataBoundItem == null)
                {
                    MessageBox.Show(
                        "Debe seleccionar una venta.",
                        "Venta no seleccionada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    return;
                }

                if (dataGridView1.CurrentRow.DataBoundItem is not VentaResumenDTO ventaResumen)
                {
                    MessageBox.Show(
                        "No se pudo obtener la venta seleccionada.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                var venta = ControladoraVenta.Instancia
                    .ObtenerVentaPorId(ventaResumen.VentaId);

                if (venta == null)
                {
                    MessageBox.Show(
                        "No se encontró la venta seleccionada.",
                        "Venta no encontrada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                frmDetalleVenta frm = new frmDetalleVenta(venta);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al ver detalle de venta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

    }
}
