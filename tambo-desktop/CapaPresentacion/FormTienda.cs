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
    public partial class FormTienda : Form
    {
        private TiendaNE tiendaNe; 
        public FormTienda()
        {
            InitializeComponent();
            tiendaNe = new TiendaNE();
        }

        private void FormTienda_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tiendaNe.ListarTienda();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormNuevaTienda formNuevaTienda = new FormNuevaTienda();
            formNuevaTienda.Show();
        }
    }
}
