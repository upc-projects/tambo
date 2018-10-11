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
    public class ProductoNE
    {
        private ProductoDAO productoDAO;

        public ProductoNE()
        {
            productoDAO = new ProductoDAO();
        }

        public DataTable ListarProductos()
        {
            return productoDAO.ListarProductos();
        }

        public int RegistrarProducto(Producto producto)
        {
            return productoDAO.RegistrarProducto(producto);
        }

        public int EliminarProducto(int id)
        {
            return productoDAO.EliminarProducto(id);
        }

        }
}
