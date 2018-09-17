using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Tienda
    {
        public int Id { get; set; }
        public Inventario objInventario { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Estado { get; set; }
        // FALTA NOMBRE(?)
    }
}
