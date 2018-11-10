using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion;

namespace Principal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void agregarTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNuevaTienda fmr = new FormNuevaTienda();
            fmr.ShowDialog();
        }

        private void listadoDeTiendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListarTienda fmr = new FormListarTienda();
            fmr.ShowDialog();
        }

        private void listarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListarInventario fmr = new FormListarInventario();
            fmr.ShowDialog();
        }

        private void editarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarInventarioTienda fmr = new ListarInventarioTienda();
            fmr.ShowDialog();
        }

        private void agregarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarMarca fmr = new FormAgregarMarca();
            fmr.ShowDialog();
        }

        private void eliminarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            FormEditarMarca fmr = new FormEditarMarca();
            fmr.ShowDialog();
        }

        private void listarMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListarMarca fmr = new FormListarMarca();
            fmr.ShowDialog();
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarProducto fmr = new FormAgregarProducto();
            fmr.ShowDialog();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditarProducto fmr = new FormEditarProducto();
            fmr.ShowDialog();
        }

        private void listarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListarProducto fmr = new FormListarProducto();
            fmr.ShowDialog();
        }

        private void agregarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarCategoria fmr = new FormAgregarCategoria();
            fmr.ShowDialog();
        }

        private void eliminarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditarCategoria fmr = new FormEditarCategoria();
            fmr.ShowDialog();
        }

        private void listarCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListarCategoria fmr = new FormListarCategoria();
            fmr.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void editarInventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormEditarInventario fmr = new FormEditarInventario();
            fmr.ShowDialog();
        }

        private void listarPorCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductoPorCategoria fmr = new FormProductoPorCategoria();
            fmr.ShowDialog();
        }

        private void listarPorMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductoPorMarca fmr = new FormProductoPorMarca();
            fmr.ShowDialog();
        }

        private void listarPorProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTiendaPorProducto fmr = new FormTiendaPorProducto();
            fmr.ShowDialog();
        }
    }
}
