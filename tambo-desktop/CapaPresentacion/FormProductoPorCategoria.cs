using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class FormProductoPorCategoria : Form
    {
        private CategoriaNE categoria;
        private ProductoNE producto;

        public FormProductoPorCategoria()
        {
            InitializeComponent();
            categoria = new CategoriaNE();
            producto = new ProductoNE();
        }

        private void FormProductoPorCategoria_Load(object sender, EventArgs e)
        {
            cboCategoria.DataSource = categoria.listarCategorias();
            cboCategoria.DisplayMember = "nombre";
            cboCategoria.ValueMember = "id";
        }

        private void LlenarProductos(int idCategoria)
        {
            DGProducto.DataSource = producto.ListarProductosCategoria(idCategoria);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Categoria objCategoria = new Categoria();
            objCategoria.Id = int.Parse(cboCategoria.SelectedValue.ToString());
            LlenarProductos(objCategoria.Id);
        }
    }
}
