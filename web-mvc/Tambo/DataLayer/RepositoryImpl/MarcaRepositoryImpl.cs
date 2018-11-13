using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataLayer.Repository;

namespace DataLayer.RepositoryImpl
{
    public class MarcaRepositoryImpl : IMarcaRepository
    {
        private TamboContext context;

        public MarcaRepositoryImpl()
        {
            context = new TamboContext();
        }

        public bool Delete(Marca t)
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

        public List<Marca> FindAll()
        {
            return context.Marcas.ToList();
        }

        public Marca FindById(int? id)
        {
            return context.Marcas
                .Find(id);
        }

        public bool Save(Marca t)
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

        public bool Update(Marca t)
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
