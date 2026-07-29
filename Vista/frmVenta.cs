using Controladora;
using Entidades;
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
    public partial class frmVenta : Form
    {
        private List<DetalleVenta> detallesVenta = new List<DetalleVenta>();
        private List<Cliente> clientes = new List<Cliente>();
        private bool filtrandoClientes = false;
        public frmVenta()
        {
            InitializeComponent();

            RefrescarGrillaDetalles();

            CargarSucursales();
            CargarClientes();
            CargarMetodosPago();

            LimpiarComboVendedores();
            LimpiarComboDescuentos();
            LimpiarComboProductos();

            int numero = ControladoraVenta.Instancia.ObtenerProximoNumeroVenta();
            lblNumeroVenta.Text = $"N° Venta: {numero}";

            dtpFechaVenta.Value = DateTime.Now;
            ActualizarTotales();
        }
        //cargo cmbSucursal
        private void CargarSucursales()
        {
            cmbSucursal.DataSource = null;
            cmbSucursal.DataSource =
                ControladoraSucursal.Instancia.ListarSucursalesActivas();

            cmbSucursal.DisplayMember = "Nombre";
            cmbSucursal.ValueMember = "SucursalId";
            cmbSucursal.SelectedIndex = -1;
            cmbSucursal.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //cargo cmbCliente
        private void CargarClientes()
        {
            cmbCliente.DataSource = null;
            cmbCliente.DataSource =
                ControladoraCliente.Instancia.ListarClientesActivos();

            cmbCliente.DisplayMember = "NumeroDocumento";
            cmbCliente.ValueMember = "ClienteId";

            cmbCliente.DropDownStyle = ComboBoxStyle.DropDown;
            cmbCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCliente.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbCliente.SelectedIndex = -1;
            cmbCliente.Text = "";
        }

        //cargo cmbMetodosPago
        private void CargarMetodosPago()
        {
            cmbMetodoPago.DataSource = null;
            cmbMetodoPago.DataSource =
                ControladoraMetodoPago.Instancia.ListarMetodosPagoActivos();

            cmbMetodoPago.DisplayMember = "Nombre";
            cmbMetodoPago.ValueMember = "MetodoPagoId";
            cmbMetodoPago.SelectedIndex = -1;
            cmbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //vaciamos cmbVendedores, xq dependen de la sucursal seleccionada
        private void LimpiarComboVendedores()
        {
            cmbVendedor.DataSource = null;
            cmbVendedor.Items.Clear();
            cmbVendedor.SelectedIndex = -1;
            cmbVendedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVendedor.Enabled = false;
        }
        //una vez se selecciona una sucursal, se cargan los vendedores 
        private void CargarVendedoresPorSucursal(int sucursalId)
        {
            cmbVendedor.DataSource = null;
            cmbVendedor.DataSource = ControladoraVendedor.Instancia.ListarVendedoresActivosPorSucursal(sucursalId);

            cmbVendedor.DisplayMember = "Apellido";
            cmbVendedor.ValueMember = "VendedorId";
            cmbVendedor.SelectedIndex = -1;
            cmbVendedor.Enabled = true;
        }
        //vaciamos cmbDescuentos xq dependen del tipo cliente
        private void LimpiarComboDescuentos()
        {
            cmbDescuento.DataSource = null;
            cmbDescuento.Items.Clear();
            cmbDescuento.SelectedIndex = -1;
            cmbDescuento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDescuento.Enabled = false;
        }
        private void CargarDescuentosPorTipoCliente(int tipoClienteId)
        {
            var descuentos = ControladoraDescuento.Instancia
                    .ListarDescuentosActivosPorTipoCliente(tipoClienteId)
                    .ToList();

            cmbDescuento.DataSource = null;
            cmbDescuento.DisplayMember = "Nombre";
            cmbDescuento.ValueMember = "DescuentoId";
            cmbDescuento.DataSource = descuentos;

            cmbDescuento.SelectedIndex = -1;
            cmbDescuento.Enabled = descuentos.Count > 0;


        }
        //vaciamos xq dependen de la sucursal
        private void LimpiarComboProductos()
        {
            cmbProducto.DataSource = null;
            cmbProducto.Items.Clear();
            cmbProducto.SelectedIndex = -1;
            cmbProducto.Enabled = false;
        }
        //cargamos una vez seleccionada la sucursal
        private void CargarProductosPorSucursal(int sucursalId)
        {
            cmbProducto.DataSource = null;
            cmbProducto.DataSource =
                ControladoraInventario.Instancia
                    .ListarInventariosPorSucursal(sucursalId);

            cmbProducto.DisplayMember = "Producto";
            cmbProducto.ValueMember = "ProductoId";
            cmbProducto.SelectedIndex = -1;
            cmbProducto.Enabled = true;

            cmbProducto.DropDownStyle = ComboBoxStyle.DropDown;
            cmbProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbProducto.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void frmVenta_Load(object sender, EventArgs e)
        {

        }



        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSucursal.SelectedValue == null || cmbSucursal.SelectedValue is not int sucursalId)
            {
                LimpiarComboVendedores();
                LimpiarComboProductos();
                return;
            }

            CargarVendedoresPorSucursal(sucursalId);
            CargarProductosPorSucursal(sucursalId);
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedItem is Cliente cliente)
            {
                lblNombreCliente.Text =
                    $"Cliente: {cliente.Nombre}";

                CargarDescuentosPorTipoCliente(
                    cliente.TipoClienteId
                );
            }
            else
            {
                lblNombreCliente.Text = "Cliente: -";

                cmbDescuento.DataSource = null;
                cmbDescuento.Enabled = false;
            }
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedItem is not Inventario inventario)
            {

                lblPrecio.Text = "Precio: $0,00";
                lblStockDisponible.Text = "Stock: 0";
                return;
            }



            lblPrecio.Text =
                $"Precio: {inventario.Producto.MontoUnitario:C2}";

            lblStockDisponible.Text =
                $"Stock: {inventario.StockProducto}";
        }

        private void cmbDescuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarTotales();
        }
        //para el final del evento del btnAgregarProducto
        private void LimpiarProductoSeleccionado()
        {
            cmbProducto.SelectedIndex = -1;
            cmbProducto.Text = "";

            lblPrecio.Text = "Precio: $0,00";
            lblStockDisponible.Text = "Stock: 0";

            nudUnidades.Value = 0;
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProducto.SelectedItem is not Inventario inventario)
                {
                    MessageBox.Show(
                        "Debe seleccionar un producto.",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                int cantidad = (int)nudUnidades.Value;

                if (cantidad <= 0)
                {
                    MessageBox.Show(
                        "La cantidad debe ser mayor a cero.",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                DetalleVenta? detalleExistente =
                    detallesVenta.FirstOrDefault(d =>
                        d.ProductoId == inventario.ProductoId);

                if (detalleExistente != null)
                {
                    int nuevaCantidad =
                        detalleExistente.Cantidad + cantidad;

                    if (nuevaCantidad > inventario.StockProducto)
                    {
                        MessageBox.Show(
                            "La cantidad supera el stock disponible.",
                            "Stock insuficiente",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        return;
                    }

                    detalleExistente.Cantidad = nuevaCantidad;

                    detalleExistente.Subtotal =
                        detalleExistente.PrecioUnitario
                        * detalleExistente.Cantidad;

                    RefrescarGrillaDetalles();

                    MessageBox.Show(
                        "La cantidad del producto fue actualizada.",
                        "Detalle actualizado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    if (cantidad > inventario.StockProducto)
                    {
                        MessageBox.Show(
                            "La cantidad supera el stock disponible.",
                            "Stock insuficiente",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        return;
                    }

                    DetalleVenta nuevoDetalle =
                        new DetalleVenta
                        {
                            ProductoId = inventario.ProductoId,
                            //chau 
                            //Producto = inventario.Producto,
                            Cantidad = cantidad,
                            PrecioUnitario =
                                inventario.Producto.MontoUnitario,
                            Subtotal =
                                inventario.Producto.MontoUnitario
                                * cantidad
                        };

                    detallesVenta.Add(nuevoDetalle);

                    MessageBox.Show(
                        "Producto agregado a la venta.",
                        "Producto agregado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }

                RefrescarGrillaDetalles();
                ActualizarTotales();
                LimpiarProductoSeleccionado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void ActualizarTotales()
        {
            decimal subtotal =
                detallesVenta.Sum(d => d.Subtotal);

            decimal montoDescuento = 0;

            if (cmbDescuento.SelectedItem is Descuento descuento)
            {
                if (descuento.TipoDeDescuento ==
                    TipoDescuento.Porcentaje)
                {
                    montoDescuento =
                        subtotal * descuento.Valor / 100;
                }
                else if (descuento.TipoDeDescuento ==
                         TipoDescuento.Fijo)
                {
                    montoDescuento = descuento.Valor;
                }
            }

            if (montoDescuento > subtotal)
                montoDescuento = subtotal;

            decimal total = subtotal - montoDescuento;

            lblSubtotal.Text =
                $"Subtotal: {subtotal:C2}";

            lblDescuento.Text =
                $"Descuento: {montoDescuento:C2}";

            lblTotal.Text =
                $"Total: {total:C2}";
        }
        //este va
        private void RefrescarGrillaDetalles()
        {
            dgvDetalleVenta.DataSource = null;
            dgvDetalleVenta.DataSource = detallesVenta.ToList();

            if (dgvDetalleVenta.Columns["VentaId"] != null)
                dgvDetalleVenta.Columns["VentaId"].Visible = false;

            if (dgvDetalleVenta.Columns["ProductoId"] != null)
                dgvDetalleVenta.Columns["ProductoId"].Visible = false;

            if (dgvDetalleVenta.Columns["Venta"] != null)
                dgvDetalleVenta.Columns["Venta"].Visible = false;

            if (dgvDetalleVenta.Columns["Producto"] != null)
            {
                dgvDetalleVenta.Columns["Producto"].HeaderText = "Producto";
                dgvDetalleVenta.Columns["Producto"].DisplayIndex = 1;
            }

            if (dgvDetalleVenta.Columns["Cantidad"] != null)
            {
                dgvDetalleVenta.Columns["Cantidad"].HeaderText = "Cantidad";
                dgvDetalleVenta.Columns["Cantidad"].DisplayIndex = 0;
            }

            if (dgvDetalleVenta.Columns["PrecioUnitario"] != null)
            {
                dgvDetalleVenta.Columns["PrecioUnitario"].HeaderText =
                    "Precio unitario";

                dgvDetalleVenta.Columns["PrecioUnitario"].DisplayIndex = 2;
                dgvDetalleVenta.Columns["PrecioUnitario"]
                    .DefaultCellStyle.Format = "C2";
            }

            if (dgvDetalleVenta.Columns["Subtotal"] != null)
            {
                dgvDetalleVenta.Columns["Subtotal"].HeaderText = "Subtotal";
                dgvDetalleVenta.Columns["Subtotal"].DisplayIndex = 3;
                dgvDetalleVenta.Columns["Subtotal"]
                    .DefaultCellStyle.Format = "C2";
            }

            dgvDetalleVenta.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvDetalleVenta.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvDetalleVenta.MultiSelect = false;
            dgvDetalleVenta.ReadOnly = true;
        }

        //para filtrar en el cmbCliente. chau no funciono
        private void cmbCliente_TextUpdate(object sender, EventArgs e)
        {
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDetalleVenta.CurrentRow == null ||
                    dgvDetalleVenta.CurrentRow.DataBoundItem == null)
                {
                    MessageBox.Show(
                        "Debe seleccionar un producto de la venta.",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                DetalleVenta detalleSeleccionado =
                    (DetalleVenta)dgvDetalleVenta
                        .CurrentRow
                        .DataBoundItem;

                DialogResult resultado =
                    MessageBox.Show(
                        $"¿Desea quitar {detalleSeleccionado.Producto.Nombre} de la venta?",
                        "Confirmar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                if (resultado != DialogResult.Yes)
                    return;

                detallesVenta.Remove(detalleSeleccionado);

                RefrescarGrillaDetalles();
                ActualizarTotales();

                MessageBox.Show(
                    "Producto quitado de la venta.",
                    "Detalle eliminado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            try
            {
                if (detallesVenta.Count == 0)
                {
                    MessageBox.Show(
                        "No hay productos cargados en la venta.",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                DialogResult resultado =
                    MessageBox.Show(
                        "¿Desea quitar todos los productos de la venta?",
                        "Vaciar detalle",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                if (resultado != DialogResult.Yes)
                    return;

                detallesVenta.Clear();

                RefrescarGrillaDetalles();
                ActualizarTotales();
                LimpiarProductoSeleccionado();

                MessageBox.Show(
                    "Se quitaron todos los productos de la venta.",
                    "Detalle vacío",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void LimpiarCampos()
        {
            cmbCliente.SelectedIndex = -1;
            cmbSucursal.SelectedIndex = -1;
            cmbVendedor.SelectedIndex = -1;
            cmbMetodoPago.SelectedIndex = -1;
            cmbDescuento.SelectedIndex = -1;
            lblSubtotal.Text = "Subtotal: $ 0,00";
            lblDescuento.Text = "Descuento: $ 0,00";
            lblTotal.Text = "Total: $ 0,00";

            detallesVenta.Clear();

            dgvDetalleVenta.DataSource = null;
        }
        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                Venta venta = new Venta
                {
                    ClienteId = Convert.ToInt32(cmbCliente.SelectedValue),
                    SucursalId = Convert.ToInt32(cmbSucursal.SelectedValue),
                    VendedorId = Convert.ToInt32(cmbVendedor.SelectedValue),
                    MetodoPagoId = Convert.ToInt32(cmbMetodoPago.SelectedValue),

                    DescuentoId = cmbDescuento.SelectedValue == null
                        ? null
                        : Convert.ToInt32(cmbDescuento.SelectedValue),
                    //Detalles es la coleccion dentro de Venta
                    Detalles = detallesVenta
                };

                string resultado =
                    ControladoraVenta.Instancia.AgregarVenta(venta);

                if (resultado == "Venta registrada correctamente.")
                {
                    MessageBox.Show(
                        resultado,
                        "Venta registrada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        resultado,
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void lblNombreCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
