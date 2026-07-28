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
    public partial class frmInventario : Form
    {
        private Inventario? inventarioSeleccionado;
        public frmInventario()
        {

            InitializeComponent();
            dgvInventario.ReadOnly = true;
            dgvInventario.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.MultiSelect = false;

            CargarSucursalesFiltro();
            CargarProductos();
            CargarSucursales();
            Refrescar();
        }
        private void CargarProductos()
        {
            cmbProducto.DataSource =
                ControladoraProducto.Instancia.ListarProductosActivos();

            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "ProductoId";

            cmbProducto.SelectedIndex = -1;

            cmbProducto.DropDownStyle = ComboBoxStyle.DropDown;
            cmbProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbProducto.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void CargarSucursales()
        {
            cmbSucursal.DataSource =
                ControladoraSucursal.Instancia.ListarSucursalesActivas();

            cmbSucursal.DisplayMember = "Nombre";
            cmbSucursal.ValueMember = "SucursalId";

            cmbSucursal.SelectedIndex = -1;

            cmbSucursal.DropDownStyle = ComboBoxStyle.DropDown;
            cmbSucursal.AutoCompleteMode =
                AutoCompleteMode.SuggestAppend;
            cmbSucursal.AutoCompleteSource =
                AutoCompleteSource.ListItems;
        }
        private void CargarSucursalesFiltro()
        {
            cmbSucursalFiltro.DataSource =
                ControladoraSucursal.Instancia.ListarSucursales();

            cmbSucursalFiltro.DisplayMember = "Nombre";
            cmbSucursalFiltro.ValueMember = "SucursalId";

            cmbSucursalFiltro.SelectedIndex = -1;
            cmbSucursalFiltro.DropDownStyle =
                ComboBoxStyle.DropDownList;
        }
        private void Refrescar()
        {
            IReadOnlyCollection<Inventario> inventarios;

            // Si no hay sucursal seleccionada, muestra todo
            if (cmbSucursalFiltro.SelectedIndex == -1)
            {
                inventarios = ControladoraInventario
                    .Instancia
                    .ListarInventarios();
            }
            //si se selecciono una sucursal, muestra sus invetarios
            else
            {
                //agarra el id de la sucursal seleccionada en la cmb
                int sucursalId = (int)cmbSucursalFiltro.SelectedValue;

                inventarios = ControladoraInventario
                    .Instancia
                    .ListarPorSucursal(sucursalId);
            }

            // Filtra por nombre o código
            string texto = txtProductoFiltro.Text.Trim();

            //filtro del txtProductoFiltro? 
            if (texto != "")
            {
                inventarios = inventarios
                    .Where(i =>
                        i.Producto.Nombre.Contains(
                            texto,
                            StringComparison.OrdinalIgnoreCase
                        )
                        ||
                        i.Producto.Codigo.Contains(
                            texto,
                            StringComparison.OrdinalIgnoreCase
                        )
                    )
                    .ToList();
            }

            dgvInventario.DataSource = null;
            dgvInventario.DataSource = inventarios;

            ConfigurarGrilla();
        }
        private void ConfigurarGrilla()
        {
            dgvInventario.Columns["ProductoId"].Visible = false;
            dgvInventario.Columns["SucursalId"].Visible = false;

            dgvInventario.Columns["Producto"].HeaderText = "Producto";

            dgvInventario.Columns["Sucursal"].HeaderText = "Sucursal";

            dgvInventario.Columns["StockProducto"].HeaderText = "Stock";
        }

        private void LimpiarCampos()
        {
            inventarioSeleccionado = null;

            cmbProducto.SelectedIndex = -1;
            cmbSucursal.SelectedIndex = -1;

            lblCodigo.Text = "-";
            lblNombre.Text = "-";

            //nudStock.Value = 0;

            dgvInventario.ClearSelection();
        }


        private void frmInventario_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedItem is Producto producto)
            {
                lblCodigo.Text = producto.Codigo;
                lblNombre.Text = producto.Nombre;
            }
            else
            {
                lblCodigo.Text = "-";
                lblNombre.Text = "-";
            }
        }

        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        { 

        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            inventarioSeleccionado =
                (Inventario)dgvInventario
                    .Rows[e.RowIndex]
                    .DataBoundItem;

            cmbProducto.SelectedValue =
                inventarioSeleccionado.ProductoId;

            cmbSucursal.SelectedValue =
                inventarioSeleccionado.SucursalId;

            //nudStock.Value = inventarioSeleccionado.StockProducto;

        }

        private void btnAgregarStock_Click(object sender, EventArgs e)
        {
            try
            {
                if (inventarioSeleccionado == null)
                {
                    MessageBox.Show(
                        "Debe seleccionar un inventario de la grilla.",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                frmAgregarStock formulario =
                    new frmAgregarStock(
                        inventarioSeleccionado.Producto.Nombre
                    );

                if (formulario.ShowDialog() == DialogResult.OK)
                {
                    int nuevoStock =
                        inventarioSeleccionado.StockProducto
                        + formulario.CantidadIngresada;

                    Inventario inventario = new Inventario
                    {
                        ProductoId =
                            inventarioSeleccionado.ProductoId,

                        SucursalId =
                            inventarioSeleccionado.SucursalId,

                        StockProducto = nuevoStock
                    };

                    string mensaje =
                        ControladoraInventario
                            .Instancia
                            .GuardarInventario(inventario);

                    MessageBox.Show(
                        mensaje,
                        "Inventario",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    LimpiarCampos();
                    Refrescar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al agregar stock: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
