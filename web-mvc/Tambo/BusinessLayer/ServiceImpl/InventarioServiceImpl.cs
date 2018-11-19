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
    class InventarioServiceImpl : IInventarioService
    {
        private IInventarioRespository inventarioRepository;

        public InventarioServiceImpl()
        {
            inventarioRepository = new InventarioRepositoryImpl();
        }

        public bool Delete(Inventario t)
        {
            return inventarioRepository.Delete(t);
        }

        public List<Inventario> FindAll()
        {
            return inventarioRepository.FindAll();
        }

        public Inventario FindById(int? id)
        {
            return inventarioRepository.FindById(id);
        }

        public bool Save(Inventario t)
        {
            return inventarioRepository.Save(t);
        }

        public bool Update(Inventario t)
        {
            return inventarioRepository.Update(t);
        }
    }
}
