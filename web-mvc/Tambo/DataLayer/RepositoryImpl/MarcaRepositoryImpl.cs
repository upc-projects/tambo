using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataLayer.Repository;
using Entities_Layer;

namespace DataLayer.RepositoryImpl
{
    public class MarcaRepositoryImpl : IMarcaRepository
    {
        private TamboContext context;

        public MarcaRepositoryImpl()
        {
            context = new TamboContext();
        }

        public bool Delete(Marcas t)
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

        public List<Marcas> FindAll()
        {
            return context.Marcas.ToList();
        }

        public Marcas FindById(int? id)
        {
            return context.Marcas
                .Find(id);
        }

        public List<Marcas> findByNombre(string name)
        {
            return context.Marcas.OrderBy(x => x.nombre).Where(x => x.nombre.Contains(name)).ToList();
        }

        public bool Save(Marcas t)
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

        public bool Update(Marcas t)
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
