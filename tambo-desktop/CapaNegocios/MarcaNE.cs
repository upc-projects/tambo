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
    public class MarcaNE
    {
        private MarcaDAO marcaDAO;
        public MarcaNE()
        {
            marcaDAO = new MarcaDAO();
        }

        public DataTable ListarMarca()
        {
            return marcaDAO.ListarMarcas();
        }

        public int RegistrarMarca(Marca marca)
        {
            return marcaDAO.RegistrarMarca(marca);
        }


        public int EliminarMarca(int id)
        {
            return marcaDAO.EliminarMarca(id);
        }
    }
}
