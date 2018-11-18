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
    public class CategoriaRepositoryImpl : ICategoriaRepository
    {
        private TamboContext context;

        public CategoriaRepositoryImpl()
        {
            context = new TamboContext();
        }

        public bool Delete(Categorias t)
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

        public List<Categorias> FindAll()
        {
            return context.Categorias.ToList();
        }

        public Categorias FindById(int? id)
        {
            return context.Categorias.Find(id);
        }

        public bool Save(Categorias t)
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

        public bool Update(Categorias t)
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
