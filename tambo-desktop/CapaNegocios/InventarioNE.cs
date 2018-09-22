using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class InventarioNE
    {
        private InventarioDAO inventarioDAO;

        public InventarioNE()
        {
            inventarioDAO = new InventarioDAO();
        }


        public DataTable ListarInventario()
        {
            return inventarioDAO.ListarInventario();
        }

        public int RegistrarInventario(Inventario inventario)
        {
            return inventarioDAO.RegistrarInventario(inventario);
        }
    }
}
