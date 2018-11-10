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
    public partial class FormListarTienda : Form
    {
        private TiendaNE tienda;

        public FormListarTienda()
        {
            InitializeComponent();
            tienda = new TiendaNE();
        }

        private void FormListarTienda_Load(object sender, EventArgs e)
        {
            DGTiendas.DataSource = tienda.ListarTienda();
        }

        private void DGTiendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
