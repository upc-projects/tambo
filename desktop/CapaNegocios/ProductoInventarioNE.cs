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
    public class ProductoInventarioNE
    {
        private ProductoInventarioDAO productoInventarioDAO;

        public ProductoInventarioNE()
        {
            productoInventarioDAO = new ProductoInventarioDAO();
        }

        public DataTable ListarInventario()
        {
            return productoInventarioDAO.ListarInventario();
        }

        public int RegistrarProductoInventario(Inventario productoInventario)
        {
            return productoInventarioDAO.RegistrarProductoInventario(productoInventario);
        }

    }
}
