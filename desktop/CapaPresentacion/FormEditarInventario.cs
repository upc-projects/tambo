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
    public partial class FormEditarInventario : Form
    {
        private TiendaNE tienda;
        private ProductoNE producto;
        private ProductoInventarioNE productoInventario;

        public FormEditarInventario()
        {
            InitializeComponent();
            tienda = new TiendaNE();
            producto = new ProductoNE();
            productoInventario = new ProductoInventarioNE();
        }

        private void btnAgregat_Click(object sender, EventArgs e)
        {
            try
            {
                Producto objProducto = new Producto();
                objProducto.Id = int.Parse(CBProducto.SelectedValue.ToString());

                Tienda objTienda = new Tienda();
                objTienda.Id = int.Parse(CBTienda.SelectedValue.ToString());

                Inventario Objinventario = new Inventario();
                Objinventario.ObjProducto = objProducto;
                Objinventario.ObjTienda = objTienda;
                Objinventario.Stock = int.Parse(NUDCantidad.Text);

                int i = productoInventario.RegistrarProductoInventario(Objinventario);

                MessageBox.Show("Inventario registrado", "Mensaje", MessageBoxButtons.OK);
                this.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Ocurrio un error" + exception, "Mensaje", MessageBoxButtons.OK);
                throw;
            }
        }

        private void FormEditarInventario_Load(object sender, EventArgs e)
        {
            CBProducto.DataSource = producto.ListarProductos();
            CBProducto.DisplayMember = "nombre";
            CBProducto.ValueMember = "id";

            CBTienda.DataSource = tienda.ListarTienda();
            CBTienda.DisplayMember = "nombre";
            CBTienda.ValueMember = "id";
        }
    }
}
