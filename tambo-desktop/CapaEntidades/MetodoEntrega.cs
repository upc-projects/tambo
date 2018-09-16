using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class MetodoEntrega
    {
        private int Id { get; set; }
        private Motorizado objMotorizado { get; set; }
        private string DireccionEntrega { get; set; }
        private string DireccionTienda { get; set; }
        private string HoraMax { get; set; }
    }
}
