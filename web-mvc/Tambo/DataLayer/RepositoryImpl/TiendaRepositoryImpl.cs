using DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.RepositoryImpl
{
    public class TiendaRepositoryImpl : ITiendaRepository
    {

        private TamboContext context;

        public TiendaRepositoryImpl()
        {
            context = new TamboContext();
        }

        public bool Delete(Tienda t)
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

        public List<Tienda> FindAll()
        {
            return context.Tiendas.ToList();
        }

        public Tienda FindById(int? id)
        {
            return context.Tiendas
                .Find(id);
        }

        public bool Save(Tienda t)
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

        public bool Update(Tienda t)
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
