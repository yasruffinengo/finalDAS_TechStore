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
    public partial class frmSucursal : Form
    {
        private Sucursal? sucursalEnEdicion;
        public frmSucursal()
        {
            InitializeComponent();
            Refrescar();

        }
        private void Refrescar()
        {
            dgvSucursales.DataSource = null;
            dgvSucursales.DataSource = ControladoraSucursal.Instancia.ListarSucursales();
            //oculto el bool
            dgvSucursales.Columns["Activo"].Visible = false;
        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDomicilio.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtNombre.Focus();
        }
        private void LlenarCampos(Sucursal sucursal)
        {
            txtNombre.Text = sucursal.Nombre;
            txtDomicilio.Text = sucursal.Domicilio;
            txtTelefono.Text = sucursal.Telefono;
            txtEmail.Text = sucursal.Email;

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje;

                if (sucursalEnEdicion == null)
                {
                    Sucursal nuevaSucursal = new Sucursal
                    {
                        Nombre = txtNombre.Text,
                        Domicilio = txtDomicilio.Text,
                        Telefono = txtTelefono.Text,
                        Email = txtEmail.Text
                    };

                    mensaje = ControladoraSucursal
                        .Instancia
                        .AgregarSucursal(nuevaSucursal);
                }
                else
                {
                    sucursalEnEdicion.Nombre = txtNombre.Text;
                    sucursalEnEdicion.Domicilio = txtDomicilio.Text;
                    sucursalEnEdicion.Telefono = txtTelefono.Text;
                    sucursalEnEdicion.Email = txtEmail.Text;

                    mensaje = ControladoraSucursal
                        .Instancia
                        .ModificarSucursal(sucursalEnEdicion);
                }
                // el bool es true en uno de esos dos casos, sino FALSE.
                bool operacionExitosa =
                    mensaje == "Sucursal agregada correctamente." ||
                    mensaje == "Sucursal modificada correctamente.";

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

                sucursalEnEdicion = null;
                LimpiarCampos();
                Refrescar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar la sucursal: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }

        private void frmSucursal_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvSucursales.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una sucursal para editar.");
                return;
            }

            sucursalEnEdicion = (Sucursal)dgvSucursales.CurrentRow.DataBoundItem;
            LlenarCampos(sucursalEnEdicion);
            txtNombre.Focus();
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                //databounditem es el objeto de la fila.
                if (dgvSucursales.CurrentRow == null ||
                    dgvSucursales.CurrentRow.DataBoundItem == null)
                {
                    MessageBox.Show(
                        "Debe seleccionar una sucursal.",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                Sucursal sucursalSeleccionada =
                    (Sucursal)dgvSucursales
                        .CurrentRow
                        .DataBoundItem;

                string accion = sucursalSeleccionada.Activo
                    ? "desactivar"
                    : "activar";

                DialogResult confirmacion = MessageBox.Show(
                    $"¿Seguro que desea {accion} la sucursal " +
                    $"\"{sucursalSeleccionada.Nombre}\"?",
                    "Confirmar cambio de estado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion != DialogResult.Yes)
                {
                    return;
                }

                string mensaje = ControladoraSucursal
                    .Instancia
                    .CambiarEstadoSucursal(
                        sucursalSeleccionada.SucursalId
                    );

                bool operacionExitosa =
                    mensaje == "Sucursal activada correctamente." ||
                    mensaje == "Sucursal desactivada correctamente.";

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

                sucursalEnEdicion = null;
                LimpiarCampos();
                Refrescar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cambiar el estado de la sucursal: " +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            
        }
    }
    
}
