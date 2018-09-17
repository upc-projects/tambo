using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Inventario
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public List<ProductoInventario> objProductoInventarios { get; set; }
    }
}
