using Controladora;
using Entidades;
using Entidades.DTOs;
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
    public partial class frmReporteVenta : Form
    {
        //Reportes de ventas por período, producto, sucursal y vendedor
        public frmReporteVenta()
        {
            InitializeComponent();
        }

        private void Refrescar( List<ReporteVentaDTO> reportes)
        {
            dgvReportesVentas.DataSource = null;
            dgvReportesVentas.DataSource = reportes.ToList();

    
            // Evita que quede seleccionada automáticamente la primera fila del resultado.
            dgvReportesVentas.ClearSelection();
        }

        private void ConfigurarGrilla()
        {
            // El reporte es solamente de consulta: el usuario no puede editar sus resultados.
            dgvReportesVentas.ReadOnly = true;
            dgvReportesVentas.AllowUserToAddRows = false;
            dgvReportesVentas.AllowUserToDeleteRows = false;
            dgvReportesVentas.MultiSelect = false;
            dgvReportesVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Distribuye las columnas para aprovechar todo el ancho disponible.
            dgvReportesVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LimpiarCampos()
        {
            cmbFiltrarProducto.SelectedIndex = -1;
            cmbFiltrarSucursal.SelectedIndex = -1;
            cmbFiltrarVendedor.SelectedIndex = -1;
            dtpPeriodoDesde.Value = DateTime.Now.AddMonths(-1); //lo dejo con mes de diferencia para que no se vea vacio el reporte si no se selecciona nada
            dtpPeriodoHasta.Value = DateTime.Now; //hoy

        }
        //cargar los combo box 
        private void CargarSucursales()
        {
            var sucursales = ControladoraSucursal.Instancia.ListarSucursales();

            var listaSucursales = sucursales.ToList();

     
            cmbFiltrarSucursal.DataSource = listaSucursales.ToList();
            cmbFiltrarSucursal.DisplayMember = "Nombre";
            cmbFiltrarSucursal.ValueMember = "SucursalId";
            cmbFiltrarSucursal.SelectedIndex = -1;

        }
        private void CargarVendedores()
        {
            var vendedores = ControladoraVendedor.Instancia.ListarVendedores();

            var listaVendedores = vendedores.ToList();

            cmbFiltrarVendedor.DataSource = listaVendedores.ToList();
            cmbFiltrarVendedor.DisplayMember = "Nombre";
            cmbFiltrarVendedor.ValueMember = "VendedorId";
            cmbFiltrarVendedor.SelectedIndex = -1;

        }
        private void CargarProductos()
        {
            var productos = ControladoraProducto.Instancia.ListarProductos();

            var listaProductos = productos.ToList();

            // Combo para alta y modificación
            cmbFiltrarProducto.DataSource = listaProductos.ToList();
            cmbFiltrarProducto.DisplayMember = "Nombre";
            cmbFiltrarProducto.ValueMember = "ProductoId";
            cmbFiltrarProducto.SelectedIndex = -1;

        }

        private int? ObtenerProductoSeleccionado()
        {
            // null significa que el producto no debe incluirse como filtro.
            if (cmbFiltrarProducto.SelectedIndex == -1 ||
                cmbFiltrarProducto.SelectedValue == null)
            {
                return null;
            }

            return Convert.ToInt32(cmbFiltrarProducto.SelectedValue);
        }

        private int? ObtenerSucursalSeleccionada()
        {
            // null significa que el reporte debe incluir ventas de todas las sucursales
            if (cmbFiltrarSucursal.SelectedIndex == -1 ||
                cmbFiltrarSucursal.SelectedValue == null)
            {
                return null;
            }

            return Convert.ToInt32(cmbFiltrarSucursal.SelectedValue);
        }

        private int? ObtenerVendedorSeleccionado()
        {
            // null significa que el reporte debe incluir ventas de todos los vendedores
            if (cmbFiltrarVendedor.SelectedIndex == -1 ||
                cmbFiltrarVendedor.SelectedValue == null)
            {
                return null;
            }

            return Convert.ToInt32(cmbFiltrarVendedor.SelectedValue);
        }

        private void SolicitarReporte()
        {
            // Envía las fechas  y los filtros opcionales 
            var reportes = ControladoraReporte.Instancia.ReporteObtenerVentas(
                dtpPeriodoDesde.Value,
                dtpPeriodoHasta.Value,
                ObtenerProductoSeleccionado(),
                ObtenerSucursalSeleccionada(),
                ObtenerVendedorSeleccionado()
            );

            // Presenta en la grilla los datos devueltos por la consulta
            Refrescar(reportes);
        }

        private void frmReporteVenta_Load(object sender, EventArgs e)
        {
            try
            {
                // Prepara la pantalla una sola vez cuando se abre el formulario.
                ConfigurarGrilla();
                CargarSucursales();
                CargarProductos();
                CargarVendedores();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al cargar el formulario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnSolicitarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                // ejecuta la consulta únicamente cuando el usuario bace click
                SolicitarReporte();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al solicitar el reporte",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
