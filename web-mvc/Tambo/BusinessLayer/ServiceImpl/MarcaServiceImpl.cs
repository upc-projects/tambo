using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Service;
using DataLayer;
using DataLayer.Repository;
using DataLayer.RepositoryImpl;

namespace BusinessLayer.ServiceImpl
{
    public class MarcaServiceImpl : MarcaService
    {

        private IMarcaRepository marcaRepository;

        public MarcaServiceImpl()
        {
            marcaRepository = new MarcaRepositoryImpl();
        }

        public bool Delete(Marca t)
        {
            return marcaRepository.Delete(t);
        }

        public List<Marca> FindAll()
        {
            return marcaRepository.FindAll();
        }

        public Marca FindById(int? id)
        {
            return marcaRepository.FindById(id);
        }

        public bool Save(Marca t)
        {
            return marcaRepository.Save(t);
        }

        public bool Update(Marca t)
        {
            return marcaRepository.Update(t);
        }
    }
}
