using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Inventario
    {
        public int Id { get; set; }
        public double total { get; set; }
        private List<DetalleVenta> ListDetalleVentas { get; set; }
    }
}
