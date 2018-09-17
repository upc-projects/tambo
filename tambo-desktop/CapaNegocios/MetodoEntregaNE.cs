using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class MetodoEntregaNE
    {

        private MetodoEntregaDAO metodoEntregaDAO;

        public MetodoEntregaNE()
        {
            metodoEntregaDAO = new MetodoEntregaDAO();
        }

        public DataTable ListarMetodoEntrega()
        {
            return metodoEntregaDAO.ListarMetodoEntrega();
        }

        public int RegistrarMetodoEntrega(MetodoEntrega metodoEntrega)
        {
            return metodoEntregaDAO.RegistrarMetodoEntrega(metodoEntrega);
        }



        }
}
