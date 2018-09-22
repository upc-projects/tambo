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

namespace Principal
{
    public partial class FormNuevoInventario : Form
    {
        private TiendaNE tiendaNe;
        private ProductoInventarioNE productoInventarioNe;

        public FormNuevoInventario()
        {
            InitializeComponent();
            tiendaNe = new TiendaNE();
            productoInventarioNe = new ProductoInventarioNE();
        }

        private void FormNuevoInventario_Load(object sender, EventArgs e)
        {
            comboBoxTienda.DataSource = tiendaNe.ListarTienda();
            comboBoxTienda.DisplayMember = "NOMBRE";
            comboBoxTienda.ValueMember = "ID";
            //comboboxtienda.datasource = productone.listarproductos();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = new Producto();
                Tienda tienda = new Tienda();
                tienda.Id = Int32.Parse(comboBoxTienda.SelectedValue.ToString());
                producto.Id = 1; // VALOR ID DEL PRODUCTO
                ProductoInventario pi = new ProductoInventario();
                pi.Stock =Int32.Parse(TextBoxStock.Text);
                pi.ObjTienda = tienda;
                pi.ObjProducto = producto;
                pi.Subtotal = 0;
                productoInventarioNe.RegistrarProductoInventario(pi);
                MessageBox.Show("STOCK REGISTRADO");
            }
            catch (Exception exception)
            {
                MessageBox.Show("ERROR : " + exception.Message)
                throw;
            }
            
        }
    }
}
