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
    public partial class frmDescuento : Form
    {
        private Descuento? descuentoEnEdicion;

        public frmDescuento()
        {
            InitializeComponent();
            CargarTiposCliente();
            CargarTiposDescuento();
            Refrescar();
        }
        private void Refrescar()
        {
            dgvDescuentos.DataSource = null;
            dgvDescuentos.DataSource = ControladoraDescuento.Instancia.ListarDescuentos();
            //oculto el bool
            dgvDescuentos.Columns["Activo"].Visible = false;
            dgvDescuentos.Columns["TipoClienteId"].Visible = false;
            dgvDescuentos.Columns["Ventas"].Visible = false;

            dgvDescuentos.Columns["DescuentoId"].HeaderText = "Id";
            dgvDescuentos.Columns["TipoCliente"].HeaderText = "Tipo de cliente";
            dgvDescuentos.Columns["TipoDeDescuento"].HeaderText = "Tipo";
        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            nudValor.Value = 0;
            cmbTipoDescuento.SelectedIndex = -1;
            cmbTipoCliente.SelectedIndex = -1;
            txtNombre.Focus();
        }
        private void LlenarCampos(Descuento descuento)
        {
            txtNombre.Text = descuento.Nombre;
            txtDescripcion.Text = descuento.Descripcion;
            nudValor.Value = descuento.Valor;

            cmbTipoDescuento.SelectedItem =
                descuento.TipoDeDescuento;

            cmbTipoCliente.SelectedValue =
                descuento.TipoClienteId;

        }
        //cargo cmb
        private void CargarTiposDescuento()
        {
            cmbTipoDescuento.DataSource =
                Enum.GetValues(typeof(TipoDescuento));

            cmbTipoDescuento.SelectedIndex = -1;
        }
        //cargo cmb
        private void CargarTiposCliente()
        {
            cmbTipoCliente.DataSource =
                ControladoraTipoCliente.Instancia.ListarTiposCliente();

            cmbTipoCliente.DisplayMember = "Nombre";
            cmbTipoCliente.ValueMember = "TipoClienteId";
            cmbTipoCliente.SelectedIndex = -1;
        }
        //retorna el id de tipoCliente
        private int ObtenerTipoClienteSeleccionado()
        {
            if (cmbTipoCliente.SelectedValue == null)
                return 0;

            return Convert.ToInt32(
                cmbTipoCliente.SelectedValue
            );
        }
        //retorna id de tipoDescuento
        private TipoDescuento ObtenerTipoDescuentoSeleccionado()
        {
            if (cmbTipoDescuento.SelectedItem is TipoDescuento tipo)
                return tipo;

            return TipoDescuento.Fijo;
        }
        private void frmDescuento_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //chequea si no se selecciono nada
                if (cmbTipoDescuento.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Debe seleccionar un tipo de descuento.",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                string mensaje;

                if (descuentoEnEdicion == null)
                {
                    Descuento nuevoDescuento = new Descuento
                    {
                        Nombre = txtNombre.Text,
                        Descripcion = txtDescripcion.Text,
                        Valor = nudValor.Value,
                        //idTipoDescuento
                        TipoDeDescuento =
                            ObtenerTipoDescuentoSeleccionado(),
                        //idTipoCliente
                        TipoClienteId =
                            ObtenerTipoClienteSeleccionado()
                    };

                    mensaje = ControladoraDescuento
                        .Instancia
                        .AgregarDescuento(nuevoDescuento);
                }
                else
                {
                    descuentoEnEdicion.Nombre =
                        txtNombre.Text;
                    descuentoEnEdicion.Descripcion = txtDescripcion.Text;

                    descuentoEnEdicion.Valor =
                        nudValor.Value;

                    descuentoEnEdicion.TipoDeDescuento =
                        ObtenerTipoDescuentoSeleccionado();

                    descuentoEnEdicion.TipoClienteId =
                        ObtenerTipoClienteSeleccionado();

                    mensaje = ControladoraDescuento
                        .Instancia
                        .ModificarDescuento(
                            descuentoEnEdicion
                        );
                }

                bool operacionExitosa =
                    mensaje == "Descuento agregado correctamente." ||
                    mensaje == "Descuento modificado correctamente.";

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

                descuentoEnEdicion = null;

                LimpiarCampos();
                Refrescar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar el descuento: " +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvDescuentos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una descuento para editar.");
                return;
            }

            descuentoEnEdicion = (Descuento)dgvDescuentos.CurrentRow.DataBoundItem;
            LlenarCampos(descuentoEnEdicion);
            txtNombre.Focus();
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                //databounditem es el objeto de la fila.
                if (dgvDescuentos.CurrentRow == null ||
                    dgvDescuentos.CurrentRow.DataBoundItem == null)
                {
                    MessageBox.Show(
                        "Debe seleccionar un descuento.",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                Descuento descuentoSeleccionado =
                    (Descuento)dgvDescuentos
                        .CurrentRow
                        .DataBoundItem;

                string accion = descuentoSeleccionado.Activo
                    ? "desactivar"
                    : "activar";

                DialogResult confirmacion = MessageBox.Show(
                    $"¿Seguro que desea {accion} el descuento " +
                    $"\"{descuentoSeleccionado.Nombre}\"?",
                    "Confirmar cambio de estado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion != DialogResult.Yes)
                {
                    return;
                }

                string mensaje = ControladoraDescuento
                    .Instancia
                    .CambiarEstadoDescuento(
                        descuentoSeleccionado.DescuentoId
                    );

                bool operacionExitosa =
                    mensaje == "Descuento activado correctamente." ||
                    mensaje == "Descuento desactivado correctamente.";

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

                descuentoEnEdicion = null;
                LimpiarCampos();
                Refrescar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cambiar el estado del descuento: " +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void dgvDescuentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
