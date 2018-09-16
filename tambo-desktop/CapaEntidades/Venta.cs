using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Venta
    {
        private int Id { get; set; }
        private Tienda objTienda { get; set; }
        private MetodoEntrega objMetodoEntrega { get; set; }
        private Cliente objCliente { get; set; }
        private string Fecha { get; set; }
        private double Descuento { get; set; }
        private double Total { get; set; }
        private List<DetalleVenta> objDetalleVentas { get; set; }
    }
}
