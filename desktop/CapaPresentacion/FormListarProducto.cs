using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormListarProducto : Form
    {
        private int productoSeleccionado;
        private ProductoNE productoNE;
        public FormListarProducto()
        {
            InitializeComponent();
            productoNE = new ProductoNE();
        }

        private void FormListarProducto_Load(object sender, EventArgs e)
        {
            dataGridViewProductos.DataSource = productoNE.ListarProductos();
        }

        private void buttonProductoEliminar_Click(object sender, EventArgs e)
        {
            productoNE.EliminarProducto(productoSeleccionado);
        }

        private void dataGridViewProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productoSeleccionado = int.Parse(dataGridViewProductos.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
