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
    public  class ClienteNE
    {
        private ClienteDAO clienteDAO;

        public ClienteNE()
        {
            clienteDAO = new ClienteDAO();
        }

        public DataTable ListarClientes()
        {
      
            return clienteDAO.ListarClientes();
        }

        public int RegistrarCliente(Cliente cliente)
        {
            return clienteDAO.RegistrarCliente(cliente);
        }


    }
}
