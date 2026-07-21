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
    public partial class frmCliente : Form
    {
        private Cliente clienteEnEdicion;
        public frmCliente()
        {
            InitializeComponent();
            CargarTiposCliente();
            dgvClientes.ReadOnly = true;
            Refrescar();
        }
        private void Refrescar()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = ControladoraCliente.ControladoraCliente.Instancia.ListarClientes();
            //oculto el bool
            dgvClientes.Columns["Activo"].Visible = false;
        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtDomicilio.Clear();
            cmbTiposCliente.SelectedIndex = 0;
        }

        //para cargar el cmbTipoCliente
        private void CargarTiposCliente()
        {
            cmbTiposCliente.DataSource = ControladoraTipoCliente.Instancia.ListarTiposCliente();

            cmbTiposCliente.DisplayMember = "Nombre";
            cmbTiposCliente.ValueMember = "TipoClienteId";
        }
        private void frmCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (clienteEnEdicion == null)
            {
                Cliente cliente = new Cliente();


                try
                {
                    cliente.Nombre = txtNombre.Text;
                    cliente.NumeroDocumento = txtDni.Text;
                    cliente.Telefono = txtTelefono.Text;
                    cliente.Email = txtEmail.Text;
                    cliente.Domicilio = txtDomicilio.Text;
                    cliente.TipoClienteId = (int)cmbTiposCliente.SelectedValue;

                    // Llamar a la controladora y recibir el resultado
                    string mensaje = ControladoraCliente.ControladoraCliente.Instancia.AgregarCliente(cliente);

                    // Mostrar el resultado
                    MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Si se agregó correctamente, limpiar los campos
                    if (mensaje == "Cliente agregado correctamente.")
                        LimpiarCampos();

                }
                catch (Exception ex)
                {
                    throw new Exception("error al guardar cliente");
                }
            }
            else
            {
                clienteEnEdicion.Nombre = txtNombre.Text;
                clienteEnEdicion.NumeroDocumento = txtDni.Text;
                clienteEnEdicion.Telefono = txtTelefono.Text;
                clienteEnEdicion.Email = txtEmail.Text;
                clienteEnEdicion.Domicilio = txtDomicilio.Text;

                string mensaje = ControladoraCliente.ControladoraCliente.Instancia.ModificarCliente(clienteEnEdicion);

                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clienteEnEdicion = null; // salí del modo edición
                LimpiarCampos();
            }

            Refrescar();
        }

        private void LlenarCampos(Cliente cliente)
        {
            txtNombre.Text = cliente.Nombre.ToString();
            txtDni.Text = cliente.NumeroDocumento.ToString();
            txtTelefono.Text = cliente.Telefono.ToString();
            txtEmail.Text = cliente.Email.ToString();
            txtDomicilio.Text = cliente.Domicilio.ToString();
            cmbTiposCliente.SelectedValue = cliente.TipoClienteId;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente para editar.");
                return;
            }

            clienteEnEdicion = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            LlenarCampos(clienteEnEdicion);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente para eliminar.");
                return;
            }

            
            Cliente clienteSeleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;

            // Confirmación (opcional)
            DialogResult confirmacion = MessageBox.Show(
                "¿Seguro que desea eliminar este cliente?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.No)
                return;
            string mensaje = ControladoraCliente.ControladoraCliente.Instancia.EliminarCliente(clienteSeleccionado.ClienteId);

            MessageBox.Show(mensaje);

            Refrescar();
        }
    }
}
