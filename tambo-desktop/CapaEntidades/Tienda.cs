using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Tienda
    {
        private int Id { get; set; }
        private Inventario objInventario { get; set; }
        private string Telefono { get; set; }
        private string Direccion { get; set; }
        private string Estado { get; set; }
    }
}
