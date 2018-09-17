using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class DetalleVenta
    {
        public Producto ObjProducto { get; set; }
        public Venta objVenta { get; set; }
        public int Cantidad { get; set; }
        public double SubTotal { get; set; }
    }
}
