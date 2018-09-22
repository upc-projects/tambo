using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaInventario inventario = new FormListaInventario();
            
            inventario.MdiParent = this.MdiParent;
            inventario.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNuevoProveedor formProveedor = new FormNuevoProveedor();
            formProveedor.Show();
        }

        private void tiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTienda formTienda = new FormTienda();
            formTienda.Show();
        }
    }
}
