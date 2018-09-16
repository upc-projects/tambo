using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    class DetalleVenta
    {
        private Producto ObjProducto { get; set; }
        // OBJETO VENTA
        private int Cantidad { get; set; }
        private double SubTotal { get; set; }
    }
}
