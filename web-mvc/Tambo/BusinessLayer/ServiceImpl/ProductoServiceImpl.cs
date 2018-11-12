using BusinessLayer.Service;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ServiceImpl
{
    class ProductoServiceImpl : CrudService<Producto>
    {
        public ProductoServiceImpl()
        {
        }

        public bool Delete(Producto t)
        {
            throw new NotImplementedException();
        }

        public List<Producto> FindAll()
        {
            throw new NotImplementedException();
        }

        public Producto FindById(int? id)
        {
            throw new NotImplementedException();
        }

        public bool Save(Producto t)
        {
            throw new NotImplementedException();
        }

        public bool Update(Producto t)
        {
            throw new NotImplementedException();
        }
    }
}
