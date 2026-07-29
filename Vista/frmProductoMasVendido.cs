using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladora;
using Entidades.Dtos;

namespace Vista
{
    public partial class frmProductoMasVendido : Form
    {
        public frmProductoMasVendido()
        {
            InitializeComponent();
        }

        private void ConfigurarGrilla()
        {
            // el reporte es solamente de consulta.
            dgvProductosMasVendidos.ReadOnly = true;            
        }

        private void Refrescar(List<ProductoMasVendidoDTO> productos)
        {
            // reemplaza los resultados anteriores actualizado.
            dgvProductosMasVendidos.DataSource = null;
            dgvProductosMasVendidos.DataSource = productos.ToList(); //actualiza


            // evita que quede seleccionada la primera fila
            dgvProductosMasVendidos.ClearSelection();
        }

        private void CargarProductosMasVendidos()
        {
            // consulta 
            var productos = ControladoraReporte.Instancia.ObtenerProductosMasVendidos(
                DateTime.MinValue, //x default
                DateTime.Today, //x default
                null
            );

            // devuelve los productos ordenados por cantidad vendida
            Refrescar(productos);
        }

        private void frmProductoMasVendido_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarGrilla();
                CargarProductosMasVendidos(); //actualiza la grilla 
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al cargar los productos más vendidos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
