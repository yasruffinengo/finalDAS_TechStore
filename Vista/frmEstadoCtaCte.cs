using Controladora;
using Entidades.DTOs;

namespace Vista
{
    public partial class frmEstadoCtaCte : Form
    {
        private bool cargandoClientes;

        public frmEstadoCtaCte()
        {
            InitializeComponent();
        }

        private void frmEstadoCtaCte_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarGrillas();
                CargarClientes();
                SolicitarReporte();
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
        }

        private void ConfigurarGrillas()
        {
            ConfigurarGrilla(dgvResumen);
            ConfigurarGrilla(dgvDetalle);
        }

        private static void ConfigurarGrilla(DataGridView grilla)
        {
            grilla.ReadOnly = true;
            grilla.AllowUserToAddRows = false;
            grilla.AllowUserToDeleteRows = false;
            grilla.MultiSelect = false;
            grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarClientes()
        {
            cargandoClientes = true;

            List<EstadoCuentaClienteDTO> clientes =
                ControladoraReporte.Instancia
                    .ObtenerEstadoCuentasCorrientes(null);

            clientes.Insert(0, new EstadoCuentaClienteDTO
            {
                IdCliente = 0,
                Cliente = "Todos los clientes"
            });

            cmbCliente.DataSource = clientes;
            cmbCliente.DisplayMember = "Cliente";
            cmbCliente.ValueMember = "IdCliente";
            cmbCliente.SelectedIndex = 0;

            cargandoClientes = false;
        }

        private int? ObtenerClienteSeleccionado()
        {
            if (cmbCliente.SelectedValue == null)
                return null;

            int clienteId = Convert.ToInt32(cmbCliente.SelectedValue);
            return clienteId > 0 ? clienteId : null;
        }

        private void SolicitarReporte()
        {
            int? clienteId = ObtenerClienteSeleccionado();

            dgvResumen.DataSource = null;
            dgvResumen.DataSource = ControladoraReporte.Instancia
                .ObtenerEstadoCuentasCorrientes(clienteId);

            ConfigurarColumnasResumen();

            dgvDetalle.DataSource = null;
            if (clienteId.HasValue)
            {
                dgvDetalle.DataSource = ControladoraReporte.Instancia
                    .ObtenerDetalleCuentaCorriente(clienteId.Value);
            }

            ConfigurarColumnasDetalle();
            dgvResumen.ClearSelection();
            dgvDetalle.ClearSelection();
        }

        private void ConfigurarColumnasResumen()
        {
            if (dgvResumen.Columns["IdCliente"] != null)
                dgvResumen.Columns["IdCliente"].Visible = false;

            FormatearMoneda(dgvResumen, "TotalCompras", "Total comprado");
            FormatearMoneda(dgvResumen, "TotalPagado", "Total pagado");
            FormatearMoneda(dgvResumen, "SaldoPendiente", "Saldo pendiente");
        }

        private void ConfigurarColumnasDetalle()
        {
            if (dgvDetalle.Columns["VentaId"] != null)
                dgvDetalle.Columns["VentaId"].Visible = false;

            if (dgvDetalle.Columns["Saldada"] != null)
                dgvDetalle.Columns["Saldada"].Visible = false;

            if (dgvDetalle.Columns["NumeroVenta"] != null)
                dgvDetalle.Columns["NumeroVenta"].HeaderText = "Nro. venta";

            if (dgvDetalle.Columns["FechaVenta"] != null)
            {
                dgvDetalle.Columns["FechaVenta"].HeaderText = "Fecha de venta";
                dgvDetalle.Columns["FechaVenta"].DefaultCellStyle.Format = "g";
            }

            if (dgvDetalle.Columns["FechaSaldada"] != null)
            {
                dgvDetalle.Columns["FechaSaldada"].HeaderText = "Fecha de pago";
                dgvDetalle.Columns["FechaSaldada"].DefaultCellStyle.Format = "g";
            }

            FormatearMoneda(dgvDetalle, "MontoTotal", "Importe");
        }

        private static void FormatearMoneda(
            DataGridView grilla,
            string columna,
            string encabezado)
        {
            if (grilla.Columns[columna] == null)
                return;

            grilla.Columns[columna].HeaderText = encabezado;
            FormatoMoneda.Aplicar(grilla.Columns[columna]);
        }

        private void cmbCliente_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (cargandoClientes)
                return;

            try
            {
                SolicitarReporte();
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
        }

        private static void MostrarError(string mensaje)
        {
            MessageBox.Show(
                mensaje,
                "Error al consultar cuentas corrientes",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
}
