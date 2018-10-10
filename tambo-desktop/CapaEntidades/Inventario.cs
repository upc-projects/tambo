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
        public string Descripcion { get; set; }
        private List<ProductoInventario> ListProductoInventarios { get; set; }
    }
}
