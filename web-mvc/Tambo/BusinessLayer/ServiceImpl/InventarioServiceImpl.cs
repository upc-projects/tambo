using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Service;
using Entities_Layer;

namespace BusinessLayer.ServiceImpl
{
    class InventarioServiceImpl : InventarioService
    {
        private InventarioServiceImpl inventarioRepository;

        public InventarioServiceImpl()
        {
            inventarioRepository = new InventarioServiceImpl();
        }

        public bool Save(Inventario t)
        {
            return inventarioRepository.Save(t);
        }

        public bool Update(Inventario t)
        {
            return inventarioRepository.Update(t);
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
    }
}
