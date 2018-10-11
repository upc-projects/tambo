using CapaEntidades;
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
    public partial class FormAgregarProducto : Form
    {
        private CategoriaNE categoriaNE;
        private MarcaNE marcaNE;
        private ProductoNE productoNE;
        public FormAgregarProducto()
        {
            InitializeComponent();

            categoriaNE = new CategoriaNE();
            marcaNE = new MarcaNE();
            productoNE = new ProductoNE();
        }

        void llenarMarca()
        {
            comboBoxMarca.DataSource = marcaNE.ListarMarca();
            comboBoxMarca.DisplayMember = "nombre";
            comboBoxMarca.ValueMember = "id";
        }
        void llenarCategoria()
        {
            comboBoxCategoria.DataSource = categoriaNE.listarCategorias();
            comboBoxMarca.DisplayMember = "nombre";
            comboBoxMarca.ValueMember = "id";
        }

        private void buttonGuardarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Marca marca = new Marca();
                Categoria categoria = new Categoria();
                Producto producto = new Producto();

                marca.Id = int.Parse(comboBoxMarca.SelectedValue.ToString());
                categoria.Id = int.Parse(comboBoxCategoria.SelectedValue.ToString());

                producto.objMarca = marca;
                producto.ObjCategoria = categoria;
                producto.Nombre = textBoxNombre.Text;
                producto.Descripcion = textBoxDescripcion.Text;
                producto.Precio = double.Parse(textBoxPrecio.Text);
                producto.Codigo = textBoxCodigo.Text;
                producto.FechaCaducida = textBoxFechaV.Text;
                producto.Estado = textBoxEstado.Text;

                int i = productoNE.RegistrarProducto(producto);

                MessageBox.Show("Producto Guardado " + MessageBoxButtons.OK);
                this.Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ocurrio un error" + exception, "Mensaje", MessageBoxButtons.OK);
                throw;
            }
        }

        private void buttonNuevaMarca_Click(object sender, EventArgs e)
        {
            FormAgregarMarca fmr = new FormAgregarMarca();
            fmr.ShowDialog();
        }

        private void buttonNuevaCategoria_Click(object sender, EventArgs e)
        {
            
            FormAgregarCategoria fmr = new FormAgregarCategoria();
            fmr.ShowDialog();

        }
    }
}
