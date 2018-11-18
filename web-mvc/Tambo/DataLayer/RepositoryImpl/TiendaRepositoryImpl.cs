using DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities_Layer;

namespace DataLayer.RepositoryImpl
{
    public class TiendaRepositoryImpl : ITiendaRepository
    {

        private TamboContext context;

        public TiendaRepositoryImpl()
        {
            context = new TamboContext();
        }

        public bool Delete(Tiendas t)
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

        public List<Tiendas> FindAll()
        {
            return context.Tiendas.ToList();
        }

        public Tiendas FindById(int? id)
        {
            return context.Tiendas
                .Find(id);
        }

        public bool Save(Tiendas t)
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

        public bool Update(Tiendas t)
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
