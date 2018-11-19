using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Inventario
    {
        public Tienda ObjTienda { get; set; }
        public Producto ObjProducto { get; set; }
        public int Stock { get; set; }
    }
}
