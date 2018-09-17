using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class MetodoEntrega
    {
        public int Id { get; set; }
        public Motorizado objMotorizado { get; set; }
        public string DireccionEntrega { get; set; }
        public string DireccionTienda { get; set; }
        public string HoraMax { get; set; }
    }
}
