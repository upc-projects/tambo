using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Producto
    {
        private int Id { get; set; }

        private Marca objMarca { get; set; }
        private Proveedor objProveedor { get; set; }
        private string Nombre { get; set; }
        private string Descripcion { get; set; }
        private double Precio { get; set; }
        private string Codigo { get; set; }
        private string FechaCaducida { get; set; }
        private string Estado { get; set; }
        private string Categoria { get; set; }
    }
}
