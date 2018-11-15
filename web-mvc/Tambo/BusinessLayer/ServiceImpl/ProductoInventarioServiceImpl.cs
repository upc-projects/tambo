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
    public class ProductoInventarioServiceImpl : IProductoInventarioService
    {
        private IProductoInventarioRespository productoInventarioRespository;

        public ProductoInventarioServiceImpl()
        {
            productoInventarioRespository = new ProductoInventarioRepositoryImpl();
        }

        public bool Delete(Producto_Inventario t)
        {
            return productoInventarioRespository.Delete(t);
        }

        public List<Producto_Inventario> FindAll()
        {
            return productoInventarioRespository.FindAll();
        }

        public Producto_Inventario FindById(int? id)
        {
            return productoInventarioRespository.FindById(id);
        }

        public bool Save(Producto_Inventario t)
        {
            return productoInventarioRespository.Save(t);
        }

        public bool Update(Producto_Inventario t)
        {
            return productoInventarioRespository.Update(t);
        }
    }
}
