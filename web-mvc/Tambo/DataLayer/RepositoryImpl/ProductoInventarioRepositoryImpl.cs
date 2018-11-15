using DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.RepositoryImpl
{
    public class ProductoInventarioRepositoryImpl : IProductoInventarioRespository
    {

        private TamboContext context;

        public ProductoInventarioRepositoryImpl()
        {
            context = new TamboContext();
        }

        public bool Delete(Producto_Inventario t)
        {
            try
            {
                context.Entry(t).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public List<Producto_Inventario> FindAll()
        {
            return context.Producto_Inventario.ToList();
        }

        public Producto_Inventario FindById(int? id)
        {
            return context.Producto_Inventario.Find(id);
        }

        public bool Save(Producto_Inventario t)
        {
            try
            {
                context.Entry(t).State = EntityState.Added;
                context.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool Update(Producto_Inventario t)
        {
            try
            {
                context.Entry(t).State = EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
