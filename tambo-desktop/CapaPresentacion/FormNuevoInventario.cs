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
        private DetalleVentaNE detalleVentaNe;
        private InventarioNE inventarioNe;

        public FormNuevoInventario()
        {
            InitializeComponent();
            tiendaNe = new TiendaNE();
            detalleVentaNe = new DetalleVentaNE();
        }

        private void FormNuevoInventario_Load(object sender, EventArgs e)
        {
            comboBoxTienda.DataSource = tiendaNe.ListarTienda();
            // comboboxtienda.datasource = productone.listarproductos();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DetalleVenta detalleVenta = new DetalleVenta();
            detalleVenta.Cantidad = Int32.Parse(TextBoxStock.Text);
        }
    }
}
