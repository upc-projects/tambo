using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Inventario
    {
        private int Id { get; set; }
        private string Descripcion { get; set; }
        private List<ProductoInventario> objProductoInventarios { get; set; }
    }
}
