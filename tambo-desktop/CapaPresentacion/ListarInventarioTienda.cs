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
    public partial class ListarInventarioTienda : Form
    {
        private TiendaNE tienda;
        private InventarioNE inventario;

        public ListarInventarioTienda()
        {
            InitializeComponent();
            tienda = new TiendaNE();
            inventario = new InventarioNE();
        }

        private void ListarInventarioTienda_Load(object sender, EventArgs e)
        {
            cboTienda.DataSource = tienda.ListarTienda();
            cboTienda.DisplayMember = "nombre";
            cboTienda.ValueMember = "id_inventario";
        }

        private void LlenarInvetario(int id)
        {
            DGInventario.DataSource = tienda.ListarDetalleInventario(id);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Inventario objInventario = new Inventario();
            objInventario.Id = int.Parse(cboTienda.SelectedValue.ToString());
            LlenarInvetario(objInventario.Id);
        }
    }
}
