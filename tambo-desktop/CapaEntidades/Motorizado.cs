using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Motorizado
    {
        public int Id { get; set; }
        public Tienda objTienda { get; set; }
        public string Nombre { get; set; }
        public double Calificacion { get; set; }

    }
}
