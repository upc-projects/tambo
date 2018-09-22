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

namespace Principal
{
    public partial class FormListaInventario : Form
    {
        private TiendaNE tiendaNe;
        private InventarioNE inventarioNe;

        public FormListaInventario()
        {
            InitializeComponent();
            tiendaNe = new TiendaNE();
            inventarioNe = new InventarioNE();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormNuevoInventario formNuevoInventario = new FormNuevoInventario();
            formNuevoInventario.Show();
        }

        private void FormListaInventario_Load(object sender, EventArgs e)
        {
            dataGridViewTiendas.DataSource = tiendaNe.ListarTienda();
        }
    }
}
