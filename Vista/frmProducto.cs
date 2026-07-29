using Controladora;
using ControladoraCategoria;
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
    public partial class frmProducto : Form
    {
        private Producto? productoEnEdicion;
        public frmProducto()
        {
            InitializeComponent();
            CargarCategorias();
            Refrescar();
        }

        private void Refrescar()
        {
            var productos = ControladoraProducto
                .Instancia
                .ListarProductos();

            CargarGrilla(productos);
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCodigo.Clear();
            txtDescripcion.Clear();
            nudMontoUnitario.Value = 0;
            cmbCategoria.SelectedIndex = -1;

            txtNombre.Focus();
        }
        //metodo para el btnMODIFICAR
        private void LlenarCampos(Producto producto)
        {
            txtNombre.Text = producto.Nombre;
            txtCodigo.Text = producto.Codigo;
            txtDescripcion.Text = producto.Descripcion;
            //selectedValue el valuemember = valor asociado, osea el id
            cmbCategoria.SelectedValue = producto.CategoriaId;
            nudMontoUnitario.Value = producto.MontoUnitario;

            //selectedItem espera el OBJETO
            // // LA SACO XQ NO HACE FALTA
            //cmbCategoria.SelectedItem = producto.Categoria;

        }
        //los cmb tengan las categorias
        private void CargarGrilla(IEnumerable<Producto> productos)
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productos.ToList();

            if (dgvProductos.Columns.Count == 0)
                return;

            dgvProductos.Columns["Activo"].Visible = false;
            dgvProductos.Columns["CategoriaId"].Visible = false;
            dgvProductos.Columns["Detalles"].Visible = false;
            dgvProductos.Columns["Inventarios"].Visible = false;

            dgvProductos.Columns["ProductoId"].HeaderText = "Id";
            dgvProductos.Columns["MontoUnitario"].HeaderText = "Precio";
        }

        private void CargarCategorias()
        {
            var categorias = ControladoraCategoria
                .ControladoraCategoria
                .Instancia
                .ListarCategorias();

            var listaCategorias = categorias.ToList();

            // Combo para alta y modificación
            cmbCategoria.DataSource = listaCategorias.ToList();
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "CategoriaId";
            cmbCategoria.SelectedIndex = -1;

            // Combo para búsqueda
            cmbBusquedaCategoria.DataSource = listaCategorias.ToList();
            cmbBusquedaCategoria.DisplayMember = "Nombre";
            cmbBusquedaCategoria.ValueMember = "CategoriaId";
            cmbBusquedaCategoria.SelectedIndex = -1;
        }


        //metodo para obtener valor del cmb 
        private int ObtenerCategoriaSeleccionada()
        {
            if (cmbCategoria.SelectedValue == null)
                return 0;
            //retorna ID CATEGORIA
            return Convert.ToInt32(
                cmbCategoria.SelectedValue
            );
        }


        //evento de categoria del filtro, para que filtre la grilla por categoria
        private void cmbBusquedaCategoria_SelectionChangeCommitted(
    object sender,
    EventArgs e)
        {
            try
            {
                if (cmbBusquedaCategoria.SelectedIndex == -1 ||
                    cmbBusquedaCategoria.SelectedValue == null)
                {
                    Refrescar();
                    return;
                }

                int categoriaId = Convert.ToInt32(
                    cmbBusquedaCategoria.SelectedValue
                );

                var productos = ControladoraProducto
                    .Instancia
                    .ListarProductosPorCategoria(categoriaId);

                CargarGrilla(productos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un producto para editar.");
                return;
            }

            productoEnEdicion = (Producto)dgvProductos.CurrentRow.DataBoundItem;
            LlenarCampos(productoEnEdicion);
            txtNombre.Focus();
        }
        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                //databounditem es el objeto de la fila.
                if (dgvProductos.CurrentRow == null ||
                    dgvProductos.CurrentRow.DataBoundItem == null)
                {
                    MessageBox.Show(
                        "Debe seleccionar un producto.",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                Producto productoSeleccionado =
                    (Producto)dgvProductos
                        .CurrentRow
                        .DataBoundItem;

                string accion = productoSeleccionado.Activo
                    ? "desactivar"
                    : "activar";

                DialogResult confirmacion = MessageBox.Show(
                    $"¿Seguro que desea {accion} el producto " +
                    $"\"{productoSeleccionado.Nombre}\"?",
                    "Confirmar cambio de estado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion != DialogResult.Yes)
                {
                    return;
                }

                string mensaje = ControladoraProducto
                    .Instancia
                    .CambiarEstadoProducto(
                        productoSeleccionado.ProductoId
                    );

                bool operacionExitosa =
                    mensaje == "Producto activado correctamente." ||
                    mensaje == "Producto desactivado correctamente.";

                MessageBox.Show(
                    mensaje,
                    "Resultado",
                    MessageBoxButtons.OK,
                    operacionExitosa
                        ? MessageBoxIcon.Information
                        : MessageBoxIcon.Warning
                );

                if (!operacionExitosa)
                {
                    return;
                }

                productoEnEdicion = null;
                LimpiarCampos();
                Refrescar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cambiar el estado del producto: " +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void frmProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //chequea si no se selecciono nada
                if (cmbCategoria.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Debe seleccionar una categoria.",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                string mensaje;

                if (productoEnEdicion == null)
                {
                    Producto nuevoProducto = new Producto
                    {
                        Nombre = txtNombre.Text,
                        Codigo = txtCodigo.Text,
                        Descripcion = txtDescripcion.Text,
                        MontoUnitario = nudMontoUnitario.Value,
                        CategoriaId = ObtenerCategoriaSeleccionada()
                    };

                    mensaje = ControladoraProducto
                        .Instancia
                        .AgregarProducto(nuevoProducto);
                }
                else
                {
                    productoEnEdicion.Nombre = txtNombre.Text;
                    productoEnEdicion.Codigo = txtCodigo.Text;
                    productoEnEdicion.Descripcion = txtDescripcion.Text;
                    productoEnEdicion.MontoUnitario = nudMontoUnitario.Value;
                    productoEnEdicion.CategoriaId = ObtenerCategoriaSeleccionada();

                    mensaje = ControladoraProducto
                        .Instancia
                        .ModificarProducto(
                            productoEnEdicion
                        );
                }

                bool operacionExitosa =
                    mensaje == "Producto agregado correctamente." ||
                    mensaje == "Producto modificado correctamente.";

                MessageBox.Show(
                    mensaje,
                    "Resultado",
                    MessageBoxButtons.OK,
                    operacionExitosa
                        ? MessageBoxIcon.Information
                        : MessageBoxIcon.Warning
                );

                if (!operacionExitosa)
                    return;

                productoEnEdicion = null;

                LimpiarCampos();
                Refrescar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar el producto: " +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        //evento de BusquedaNombre para que filtre la grilla por nombre
        private void txtBusquedaNombre_TextChanged(
         object sender,
         EventArgs e)
        {
            try
            {
                string nombre = txtBusquedaNombre.Text.Trim();

                var productos = ControladoraProducto
                    .Instancia
                    .ListarProductosPorNombre(nombre);

                CargarGrilla(productos);
            }
            catch (Exception ex)
            {
                //tira un  mensaje de error si hay un problema al buscar productos
                MessageBox.Show(
                    "Error al buscar productos: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btn_limpiarFiltros_Click(object sender, EventArgs e)
        {
            txtBusquedaNombre.Clear();
            cmbBusquedaCategoria.SelectedIndex = -1;
            Refrescar();
        }
    }
}
