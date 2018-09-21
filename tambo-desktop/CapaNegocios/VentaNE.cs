using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaNegocios
{
    class VentaNE
    {
        private VentaDAO ventaDAO ;

        public VentaNE()
        {
            ventaDAO = new VentaDAO();
        }


    public DataTable ListarVenta()
    { return ventaDAO.ListarVenta(); }

    public int RegistrarProveedor(Venta venta)
    { return ventaDAO.RegistrarVenta(venta); }
}
}
