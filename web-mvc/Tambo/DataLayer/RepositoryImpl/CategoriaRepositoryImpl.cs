using DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.RepositoryImpl
{
    public class CategoriaRepositoryImpl : ICategoriaRepository
    {
        private TamboContext context;

        public CategoriaRepositoryImpl()
        {
            context = new TamboContext();
        }

        public bool Delete(Categoria t)
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

        public List<Categoria> FindAll()
        {
            return context.Categorias.ToList();
        }

        public Categoria FindById(int? id)
        {
            return context.Categorias.Find(id);
        }

        public bool Save(Categoria t)
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

        public bool Update(Categoria t)
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
