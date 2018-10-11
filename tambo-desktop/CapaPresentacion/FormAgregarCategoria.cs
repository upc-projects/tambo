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
    public partial class FormAgregarCategoria : Form
    {
        private CategoriaNE categoriaNE;

        public FormAgregarCategoria()
        {
            InitializeComponent();
            categoriaNE = new CategoriaNE();
        }

        private void FormAgregarCategoria_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuardarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria categoria = new Categoria();
                categoria.Nombre = textBoxNombreCategoria.Text;

                int i = categoriaNE.RegistrarCategoria(categoria);

                MessageBox.Show("Categoria Guardada "+ MessageBoxButtons.OK);
                textBoxNombreCategoria.Text = "";
                this.Hide();
           
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ocurrio un error" + exception, "Mensaje", MessageBoxButtons.OK);
                throw;
            }
        }
    }
}
