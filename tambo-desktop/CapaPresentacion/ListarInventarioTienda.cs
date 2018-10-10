using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class ListarInventarioTienda : Form
    {
        private TiendaNE tienda;
        public ListarInventarioTienda()
        {
            InitializeComponent();
            tienda = new TiendaNE();
        }

        private void ListarInventarioTienda_Load(object sender, EventArgs e)
        {
            cboTienda.DataSource = tienda.ListarTienda();
            cboTienda.DisplayMember = "nombre";
            cboTienda.ValueMember = "id";
        }

        private void LlenarInvetario()
        {
            
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

        }
    }
}
