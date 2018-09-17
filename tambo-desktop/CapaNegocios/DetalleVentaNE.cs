using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class DetalleVentaNE
    {
        private DetalleVentaDAO detalleVentaDAO;

        public DetalleVentaNE()
        {
            detalleVentaDAO = new DetalleVentaDAO();
        }


        public DataTable ListarDetalleVenta()
        {
            return detalleVentaDAO.ListarDetalleVenta();
        }

        public int RegistrarDetalleVenta(DetalleVenta detalleVenta)
        {
            return detalleVentaDAO.RegistrarDetalleVenta(detalleVenta);
        }
    }
}
