using CapaDatos;
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

namespace Principal
{
    public partial class FormNuevoProveedor : Form
    {
        private ProveedorNE proveedorNE;
        public FormNuevoProveedor()
        {
            InitializeComponent();

            proveedorNE = new ProveedorNE();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Proveedor proveedor = new Proveedor();
                ProveedorDAO proveedorDAO = new ProveedorDAO();

                proveedor.Nombre = textBoxNombre.Text;
                proveedor.Descripcion = textBoxDescripcion.Text;
                proveedor.Telefono = textBoxTelefono.Text;
                proveedor.Direccion = textBoxDireccion.Text;
                proveedor.Email = textBoxCorreo.Text;

                int i = proveedorNE.RegistrarProveedor(proveedor);
             
                MessageBox.Show("Registro OK ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error " + ex.Message);
            }
        }
    }
}
