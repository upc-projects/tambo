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
    public partial class FormProductoPorMarca : Form
    {
        private MarcaNE marca;
        private ProductoNE producto;

        public FormProductoPorMarca()
        {
            InitializeComponent();
            marca = new MarcaNE();
            producto = new ProductoNE();
        }

        private void FormProductoPorMarca_Load(object sender, EventArgs e)
        {
            cboMarca.DataSource = marca.ListarMarca();
            cboMarca.DisplayMember = "nombre";
            cboMarca.ValueMember = "id";
        }

        private void LlenarProductos(int idMarca)
        {
            DGProducto.DataSource = producto.ListarProductosMarca(idMarca);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Marca objMarca = new Marca();
            objMarca.Id = int.Parse(cboMarca.SelectedValue.ToString());
            LlenarProductos(objMarca.Id);
        }
    }
}
