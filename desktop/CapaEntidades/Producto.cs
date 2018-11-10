using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Producto
    {
        public int Id { get; set; }
        public Marca objMarca { get; set; }
        public Categoria ObjCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public string Codigo { get; set; }
        public string FechaCaducida { get; set; }
        public string Estado { get; set; }
        public string Categoria { get; set; }
    }
}
