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
    public partial class frmCategoria : Form
    {
        //sirve para modificar
        private Categoria categoriaEnEdicion;
        public frmCategoria()
        {
            InitializeComponent();
            dgvCategorias.ReadOnly = true;
            Refrescar();
        }
        private void Refrescar()
        {
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = ControladoraCategoria.ControladoraCategoria.Instancia.ListarCategorias();
            dgvCategorias.Columns["CategoriaId"].HeaderText = "Id";
            dgvCategorias.Columns["Productos"].Visible = false;
        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (categoriaEnEdicion == null)
            {
                Categoria categoria = new Categoria();
                //lo comento xq no entiendo xq esta
                //categoria.Nombre = txtNombre.Text;

                try
                {
                    categoria.Nombre = txtNombre.Text;
                    categoria.Descripcion = txtDescripcion.Text;

                    // Llamar a la controladora y recibir el resultado
                    string mensaje = ControladoraCategoria.ControladoraCategoria.Instancia.AgregarCategoria(categoria);

                    // Mostrar el resultado
                    MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Si se agregó correctamente, limpiar los campos
                    if (mensaje == "Categoria agregada correctamente.")
                        LimpiarCampos();

                }
                catch (Exception ex)
                {
                    throw new Exception("error al guardar categoria");
                }
            }
            else
            {
                categoriaEnEdicion.Nombre = txtNombre.Text;
                categoriaEnEdicion.Descripcion = txtDescripcion.Text;

                string mensaje = ControladoraCategoria.ControladoraCategoria.Instancia.ModificarCategoria(categoriaEnEdicion);

                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                categoriaEnEdicion = null; // salí del modo edición
                LimpiarCampos();
            }

            Refrescar();
        }
        private void LlenarCampos(Categoria categoria)
        {
            txtNombre.Text = categoria.Nombre.ToString();
            txtDescripcion.Text = categoria.Descripcion.ToString();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una categoria para editar.");
                return;
            }

            categoriaEnEdicion = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            LlenarCampos(categoriaEnEdicion);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una categoria para eliminar.");
                return;
            }

            // Obtener socio de la fila seleccionada
            Categoria categoriaSeleccionada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

            // Confirmación (opcional)
            DialogResult confirmacion = MessageBox.Show(
                "¿Seguro que desea eliminar esta categoria?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.No)
                return;
            string mensaje = ControladoraCategoria.ControladoraCategoria.Instancia.EliminarCategoria(categoriaSeleccionada.CategoriaId);

            MessageBox.Show(mensaje);

            Refrescar();
        }
    }
}
