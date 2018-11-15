using DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.RepositoryImpl
{
    public class InventarioRepositoryImpl : IInventarioRespository
    {
        private TamboContext context;
        public InventarioRepositoryImpl()
        {
            context = new TamboContext();
        }


        public bool Delete(Inventario t)
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

        public List<Inventario> FindAll()
        {
            return context.Inventarios.ToList();
        }

        public Inventario FindById(int? id)
        {
            return context.Inventarios
                  .Find(id);
        }

        public bool Save(Inventario t)
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

        public bool Update(Inventario t)
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
