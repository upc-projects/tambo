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
    public partial class FormTiendaPorProducto : Form
    {
        private ProductoNE producto;
        private TiendaNE tienda;

        public FormTiendaPorProducto()
        {
            InitializeComponent();
            producto = new ProductoNE();
            tienda = new TiendaNE();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Producto objProducto = new Producto();
            objProducto.Id = int.Parse(cboProducto.SelectedValue.ToString());
            LlenarTiendas(objProducto.Id);
        }

        private void LlenarTiendas(int idProducto)
        {
            DGTienda.DataSource = tienda.ListarTiendaProducto(idProducto);
        }

        private void FormTiendaPorProducto_Load(object sender, EventArgs e)
        {
            cboProducto.DataSource = producto.ListarProductos();
            cboProducto.DisplayMember = "nombre";
            cboProducto.ValueMember = "id";
        }
    }
}
