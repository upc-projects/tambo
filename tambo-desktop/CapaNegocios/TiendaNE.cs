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
    public class TiendaNE
    {

        private  TiendaDAO  tiendaDAO;

        public TiendaNE()
        {
            tiendaDAO = new TiendaDAO();
        }


        public DataTable ListarTienda()
        {
            return tiendaDAO.ListarTiendas();
        }

        public int RegistrarTienda(Tienda tienda)
        {
            return tiendaDAO.RegistrarTienda(tienda);
        }
    }
}
