using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class frmDetalleVenta : Form
    {
        public frmDetalleVenta()
        {
            InitializeComponent();
        }

        public frmDetalleVenta(Venta venta) : this()
        {
            CargarDetalleVenta(venta);
        }

        private void CargarDetalleVenta(Venta venta)
        {
            lblVenta.Text = $"Venta: {venta.NumeroVenta}";
            lblCliente.Text = $"Cliente: {venta.Cliente?.Nombre ?? "-"}";
            lblSucursal.Text = $"Sucursal: {venta.Sucursal?.Nombre ?? "-"}";
            lblTotal.Text = $"Total: {venta.MontoTotal:C2}";

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = venta.Detalles
                .Select(detalle => new
                {
                    Producto = detalle.Producto?.Nombre ?? detalle.ProductoNombre,
                    detalle.Cantidad,
                    detalle.PrecioUnitario,
                    detalle.Subtotal
                })
                .ToList();

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dataGridView1.Columns["Producto"] != null)
                dataGridView1.Columns["Producto"].HeaderText = "Producto";

            if (dataGridView1.Columns["Cantidad"] != null)
                dataGridView1.Columns["Cantidad"].HeaderText = "Cantidad";

            if (dataGridView1.Columns["PrecioUnitario"] != null)
            {
                dataGridView1.Columns["PrecioUnitario"].HeaderText = "Precio unitario";
                dataGridView1.Columns["PrecioUnitario"].DefaultCellStyle.Format = "C2";
            }

            if (dataGridView1.Columns["Subtotal"] != null)
            {
                dataGridView1.Columns["Subtotal"].HeaderText = "Subtotal";
                dataGridView1.Columns["Subtotal"].DefaultCellStyle.Format = "C2";
            }

            dataGridView1.ClearSelection();
        }
    }
}
