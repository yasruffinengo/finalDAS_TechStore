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
    public partial class frmVendedor : Form
    {
        private Vendedor? vendedorEnEdicion;
        public frmVendedor()
        {
            InitializeComponent();
            CargarSucursales();
            Refrescar();
        }
        private void Refrescar()
        {
            dgvVendedores.DataSource = null;
            dgvVendedores.DataSource = ControladoraVendedor.Instancia.ListarVendedores();
            //oculto el bool
            dgvVendedores.Columns["Activo"].Visible = false;
            dgvVendedores.Columns["SucursalId"].Visible = false;
            dgvVendedores.Columns["VendedorId"].HeaderText = "Id";

        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            cmbSucursales.SelectedIndex = -1;
            txtNombre.Focus();
        }
        private void LlenarCampos(Vendedor vendedor)
        {
            txtNombre.Text = vendedor.Nombre;
            txtApellido.Text = vendedor.Apellido;
            txtDni.Text = vendedor.Dni;
            cmbSucursales.SelectedValue = vendedor.SucursalId;

        }
        //para cargar el cmb
        private void CargarSucursales()
        {
            cmbSucursales.DataSource = null;
            cmbSucursales.DataSource =
                ControladoraSucursal.Instancia.ListarSucursalesActivas();

            //displayMember : lo que muestra el cmb
            cmbSucursales.DisplayMember = "Nombre";
            //valeMember : valor seleccionado
            cmbSucursales.ValueMember = "SucursalId";

            cmbSucursales.SelectedIndex = -1;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmVendedor_Load(object sender, EventArgs e)
        {

        }
        //metodo para evitar errores al convertir el valor del cmb
        private int ObtenerSucursalSeleccionada()
        {
            if (cmbSucursales.SelectedValue == null)
                return 0;

            return Convert.ToInt32(cmbSucursales.SelectedValue);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje;

                if (vendedorEnEdicion == null)
                {
                    Vendedor nuevoVendedor = new Vendedor
                    {
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Dni = txtDni.Text,
                        SucursalId = ObtenerSucursalSeleccionada()
                    };

                    mensaje = ControladoraVendedor
                        .Instancia
                        .AgregarVendedor(nuevoVendedor);
                }
                else
                {
                    vendedorEnEdicion.Nombre = txtNombre.Text;
                    vendedorEnEdicion.Apellido = txtApellido.Text;
                    vendedorEnEdicion.Dni = txtDni.Text;
                    vendedorEnEdicion.SucursalId = ObtenerSucursalSeleccionada();

                    mensaje = ControladoraVendedor.Instancia
                        .ModificarVendedor(vendedorEnEdicion);
                }
                // el bool es true en uno de esos dos casos, sino FALSE.
                bool operacionExitosa =
                    mensaje == "Vendedor agregado correctamente." ||
                    mensaje == "Vendedor modificado correctamente.";

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

                vendedorEnEdicion = null;
                LimpiarCampos();
                Refrescar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar el vendedor: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvVendedores.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un vendedor para editar.");
                return;
            }

            vendedorEnEdicion = (Vendedor)dgvVendedores.CurrentRow.DataBoundItem;
            LlenarCampos(vendedorEnEdicion);
            txtNombre.Focus();
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                //databounditem es el objeto de la fila.
                if (dgvVendedores.CurrentRow == null ||
                    dgvVendedores.CurrentRow.DataBoundItem == null)
                {
                    MessageBox.Show(
                        "Debe seleccionar un vendedor.",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                Vendedor vendedorSeleccionado =
                    (Vendedor)dgvVendedores
                        .CurrentRow
                        .DataBoundItem;

                string accion = vendedorSeleccionado.Activo
                    ? "desactivar"
                    : "activar";

                DialogResult confirmacion = MessageBox.Show(
                    $"¿Seguro que desea {accion} el vendedor " +
                    $"\"{vendedorSeleccionado.Nombre}\"?",
                    "Confirmar cambio de estado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion != DialogResult.Yes)
                {
                    return;
                }

                string mensaje = ControladoraVendedor
                    .Instancia
                    .CambiarEstadoVendedor(
                        vendedorSeleccionado.VendedorId
                    );

                bool operacionExitosa =
                    mensaje == "Vendedor activado correctamente." ||
                    mensaje == "Vendedor desactivado correctamente.";

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

                vendedorEnEdicion = null;
                LimpiarCampos();
                Refrescar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cambiar el estado del vendedor: " +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
