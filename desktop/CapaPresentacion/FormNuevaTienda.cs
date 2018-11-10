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
        private InventarioNE inventario;

        public FormNuevaTienda()
        {
            InitializeComponent();
            tienda = new TiendaNE();
            inventario = new InventarioNE();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string descripcion = "Tienda en " + txtDireccion.Text;
                Tienda objTienda = new Tienda();
                Inventario objInventario = new Inventario();
                objInventario.Descripcion = descripcion;
                try
                {
                    int i = inventario.RegistrarInventario(objInventario);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }

                objInventario = inventario.ListarInventarioDireccion(descripcion);

                objTienda.Nombre = txtNombre.Text;
                objTienda.Direccion = txtDireccion.Text;
                objTienda.Telefono = txtTelefono.Text;
                objTienda.ObjInventario = objInventario;

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
