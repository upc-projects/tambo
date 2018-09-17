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
    public class MotorizadoNE
    {
        private MotorizadoDAO motorizadoDAO;

        public MotorizadoNE()
        {
            motorizadoDAO = new MotorizadoDAO();
        }


        public DataTable ListarMotorizado()
        {
            return motorizadoDAO.ListarMotorizado();
        }

        public int RegistrarMotorizado(Motorizado motorizado)
        {
            return motorizadoDAO.RegistrarMotorizado(motorizado);
        }


        }
}
