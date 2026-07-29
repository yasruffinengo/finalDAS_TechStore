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
    public partial class frmMetodoPago : Form
    {
        private MetodoPago? mpEnEdicion;
        public frmMetodoPago()
        {
            InitializeComponent();
            Refrescar();
        }
        private void Refrescar()
        {
         
            dgvMetodosPago.DataSource = null;
            dgvMetodosPago.DataSource =
                ControladoraMetodoPago.Instancia.ListarMetodosPago();

            dgvMetodosPago.Columns["Ventas"].Visible = false;
            dgvMetodosPago.Columns["MetodoPagoId"].HeaderText = "Id";
        }
        
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtNombre.Focus();
        }
        private void LlenarCampos(MetodoPago metodoPago)
        {
            txtNombre.Text = metodoPago.Nombre;
            txtDescripcion.Text = metodoPago.Descripcion;

        }
        private void frmMetodoPago_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje;

                if (mpEnEdicion == null)
                {
                    MetodoPago nuevoMP = new MetodoPago
                    {
                        Nombre = txtNombre.Text,
                        Descripcion = txtDescripcion.Text
                    };

                    mensaje = ControladoraMetodoPago
                        .Instancia
                        .AgregarMetodoPago(nuevoMP);
                }
                else
                {
                    mpEnEdicion.Nombre = txtNombre.Text;
                    mpEnEdicion.Descripcion = txtDescripcion.Text;


                    mensaje = ControladoraMetodoPago
                        .Instancia
                        .ModificarMetodoPago(mpEnEdicion);
                }
                // el bool es true en uno de esos dos casos, sino FALSE.
                bool operacionExitosa =
                    mensaje == "Metodo de pago agregado correctamente." ||
                    mensaje == "Metodo de pago modificado correctamente.";

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

                mpEnEdicion = null;
                LimpiarCampos();
                Refrescar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar Metodo de pago: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                //databounditem es el objeto de la fila.
                if (dgvMetodosPago.CurrentRow == null ||
                    dgvMetodosPago.CurrentRow.DataBoundItem == null)
                {
                    MessageBox.Show(
                        "Debe seleccionar un Metodo de pago",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                MetodoPago mpSeleccionado =
                    (MetodoPago)dgvMetodosPago
                        .CurrentRow
                        .DataBoundItem;

                string accion = mpSeleccionado.Activo
                    ? "desactivar"
                    : "activar";

                DialogResult confirmacion = MessageBox.Show(
                    $"¿Seguro que desea {accion} el Metodo de pago " +
                    $"\"{mpSeleccionado.Nombre}\"?",
                    "Confirmar cambio de estado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion != DialogResult.Yes)
                {
                    return;
                }

                string mensaje = ControladoraMetodoPago
                    .Instancia
                    .CambiarEstadoMetodoPago(
                        mpSeleccionado.MetodoPagoId
                    );

                bool operacionExitosa =
                    mensaje == "Metodo de pago activado correctamente." ||
                    mensaje == "Metodo de pago desactivado correctamente.";

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

                mpEnEdicion = null;
                LimpiarCampos();
                Refrescar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cambiar el estado del Metodo de pago: " +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvMetodosPago.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Metodo de pago para editar.");
                return;
            }

            mpEnEdicion = (MetodoPago)dgvMetodosPago.CurrentRow.DataBoundItem;
            LlenarCampos(mpEnEdicion);
            txtNombre.Focus();
        }
    }
}
