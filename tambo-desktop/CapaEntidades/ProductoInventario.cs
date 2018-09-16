using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ProductoInventario
    {
        private Inventario ObjInventario { get; set; }
        private Producto ObjProducto { get; set; }
        private int Stock { get; set; }
    }
}
