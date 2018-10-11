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
    public partial class FormListarMarca : Form
    {
        private MarcaNE marcaNE;
        private int marcaSeleccionada;
        public FormListarMarca()
        {
            InitializeComponent();
            marcaNE = new MarcaNE();
        }

        private void FormListarMarca_Load(object sender, EventArgs e)
        {
            dataGridViewMarca.DataSource = marcaNE.ListarMarca();
        }

        private void buttonAgregarMarca_Click(object sender, EventArgs e)
        {
            FormAgregarMarca frm = new FormAgregarMarca();
            frm.ShowDialog();
        }

        private void buttonEditarMarca_Click(object sender, EventArgs e)
        {
            FormEditarMarca frm = new FormEditarMarca();
            frm.ShowDialog();
        }

        private void buttonEliminarMarca_Click(object sender, EventArgs e)
        {
            marcaNE.EliminarMarca(marcaSeleccionada);
        }

        private void dataGridViewMarca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            marcaSeleccionada = int.Parse(dataGridViewMarca.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
