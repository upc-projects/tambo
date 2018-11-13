using BusinessLayer.Service;
using DataLayer;
using DataLayer.Repository;
using DataLayer.RepositoryImpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ServiceImpl
{
    public class CategoriaServiceImpl : CategoriaService
    {

        private ICategoriaRepository categoriaRepository;

        public CategoriaServiceImpl()
        {
            categoriaRepository = new CategoriaRepositoryImpl();
        }

        public bool Delete(Categoria t)
        {
            return categoriaRepository.Delete(t);
        }

        public List<Categoria> FindAll()
        {
            return categoriaRepository.FindAll();
        }

        public Categoria FindById(int? id)
        {
            return categoriaRepository.FindById(id);
        }

        public bool Save(Categoria t)
        {
            return categoriaRepository.Save(t);
        }

        public bool Update(Categoria t)
        {
            return categoriaRepository.Update(t);
        }
    }
}
