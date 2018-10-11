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
    public partial class FormAgregarMarca : Form
    {
        private MarcaNE marcaNE;
        public FormAgregarMarca()
        {
            InitializeComponent();
            marcaNE = new MarcaNE();
        }

        private void FormAgregarMarca_Load(object sender, EventArgs e)
        {
        
        }

        private void buttonGuardarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                Marca marca = new Marca();

                marca.Nombre = textBoxNombreMarca.Text;
                marca.Descripcion = textBoxDescripcion.Text;

                int i = marcaNE.RegistrarMarca(marca);
                
                MessageBox.Show("Marca Guardada " + MessageBoxButtons.OK);
                textBoxDescripcion.Text = "";
                textBoxNombreMarca.Text = "";
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
