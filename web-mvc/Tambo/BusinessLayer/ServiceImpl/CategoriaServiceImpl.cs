using BusinessLayer.Service;
using DataLayer;
using DataLayer.Repository;
using DataLayer.RepositoryImpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities_Layer;

namespace BusinessLayer.ServiceImpl
{
    public class CategoriaServiceImpl : CategoriaService
    {

        private ICategoriaRepository categoriaRepository;

        public CategoriaServiceImpl()
        {
            categoriaRepository = new CategoriaRepositoryImpl();
        }

        public bool Delete(Categorias t)
        {
            return categoriaRepository.Delete(t);
        }

        public List<Categorias> FindAll()
        {
            return categoriaRepository.FindAll();
        }

        public Categorias FindById(int? id)
        {
            return categoriaRepository.FindById(id);
        }

        public bool Save(Categorias t)
        {
            return categoriaRepository.Save(t);
        }

        public bool Update(Categorias t)
        {
            return categoriaRepository.Update(t);
        }
    }
}
