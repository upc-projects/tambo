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
    public partial class FormListarCategoria : Form
    {
        private CategoriaNE categoriaNE;
        private int categoriaSeleccionada;
        public FormListarCategoria()
        {
            InitializeComponent();
            categoriaNE = new CategoriaNE();
        }

        private void DGCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormListarCategoria_Load(object sender, EventArgs e)
        {
            DGCategoria.DataSource = categoriaNE.listarCategorias();
        }

        private void buttonCategoriaAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarCategoria fmr = new FormAgregarCategoria();
            fmr.ShowDialog();
        }

        private void buttonCategoriaEditar_Click(object sender, EventArgs e)
        {
            FormEditarCategoria frm = new FormEditarCategoria();
            frm.ShowDialog();
        }

        private void buttonCategoriaEliminar_Click(object sender, EventArgs e)
        {
            categoriaNE.EliminarCategoria(categoriaSeleccionada);
        }

        private void DGCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          categoriaSeleccionada = int.Parse(DGCategoria.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
