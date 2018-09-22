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
    public partial class FormNuevaTienda : Form
    {
        private TiendaNE tiendaNe; 

        public FormNuevaTienda()
        {
            InitializeComponent();
            tiendaNe = new TiendaNE();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            try
            {
                Tienda tienda = new Tienda();
                tienda.Nombre = textBoxNombreTienda.Text;
                tienda.Direccion = textBoxDireccion.Text;
                tienda.Estado = textBoxEstadoTienda.Text;
                tienda.Telefono = textBoxTelefonoTienda.Text;

                int i = tiendaNe.RegistrarTienda(tienda);

                MessageBox.Show("REGISTRO TIENDA EXITOSO");

            }
            catch (Exception exception)
            {
                MessageBox.Show("REGISTRO TIENDA FALLIDO : " + exception.Message);
            }
        }
    }
}
