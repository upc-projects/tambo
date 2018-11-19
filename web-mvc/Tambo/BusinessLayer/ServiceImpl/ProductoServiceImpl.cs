using BusinessLayer.Service;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Repository;
using DataLayer.RepositoryImpl;
using Entities_Layer;

namespace BusinessLayer.ServiceImpl
{
    class ProductoServiceImpl : ProductoService
    {

        private IProductoRepository productoRepository;

        public ProductoServiceImpl()
        {
            productoRepository = new ProductoRepositoryImpl();
        }

        public bool Delete(Productos t)
        {
            return productoRepository.Delete(t);
        }

        public List<Productos> FindAll()
        {
            return productoRepository.FindAll();
        }
        
        public Productos FindById(int? id)
        {
            return productoRepository.FindById(id);
        }

        public bool Save(Productos t)
        {
            return productoRepository.Save(t);
        }

        public bool Update(Productos t)
        {
            return productoRepository.Update(t);
        }
    }
}
