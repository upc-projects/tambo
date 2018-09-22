using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Venta
    {
        public int Id { get; set; }
        public Tienda objTienda { get; set; }
        public MetodoEntrega objMetodoEntrega { get; set; }
        public Cliente objCliente { get; set; }
        public string Fecha { get; set; }
        public double Descuento { get; set; }
        public double Total { get; set; }
        public List<DetalleVenta> objDetalleVentas { get; set; }
    }
}
