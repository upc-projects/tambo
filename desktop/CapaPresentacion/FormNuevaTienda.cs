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

namespace CapaPresentacion
{
    public partial class FormNuevaTienda : Form
    {
        private TiendaNE tienda;

        public FormNuevaTienda()
        {
            InitializeComponent();
            tienda = new TiendaNE();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Tienda objTienda = new Tienda();
                
                objTienda.Nombre = txtNombre.Text;
                objTienda.Direccion = txtDireccion.Text;
                objTienda.Telefono = txtTelefono.Text;

                int c = tienda.RegistrarTienda(objTienda); 

                MessageBox.Show("Tienda registrada", "Mensaje", MessageBoxButtons.OK);
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ocurrio un error" + exception, "Mensaje", MessageBoxButtons.OK);
                throw;
            }
        }
    }
}
