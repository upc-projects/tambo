using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Service;
using DataLayer;
using DataLayer.Repository;
using DataLayer.RepositoryImpl;
using Entities_Layer;

namespace BusinessLayer.ServiceImpl
{
    public class MarcaServiceImpl : MarcaService
    {

        private IMarcaRepository marcaRepository;

        public MarcaServiceImpl()
        {
            marcaRepository = new MarcaRepositoryImpl();
        }

        public bool Delete(Marcas t)
        {
            return marcaRepository.Delete(t);
        }

        public List<Marcas> FindAll()
        {
            return marcaRepository.FindAll();
        }

        public Marcas FindById(int? id)
        {
            return marcaRepository.FindById(id);
        }

        public List<Marcas> findByNombre(string name)
        {
            return marcaRepository.findByNombre(name);
        }

        public bool Save(Marcas t)
        {
            return marcaRepository.Save(t);
        }

        public bool Update(Marcas t)
        {
            return marcaRepository.Update(t);
        }
    }
}
