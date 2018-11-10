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
    public class CategoriaNE
    {
        private CategoriaDAO categoriaDAO;

        public CategoriaNE()
        {
            categoriaDAO = new CategoriaDAO();
        }

        public DataTable listarCategorias()
        {
            return categoriaDAO.ListarCategoria();
        }

        public int RegistrarCategoria(Categoria categoria)
        {
            return categoriaDAO.RegistrarCategoria(categoria);
        }

        public int EliminarCategoria(int id)
        {
            return categoriaDAO.EliminarCategoria(id);
        }
    }
}
