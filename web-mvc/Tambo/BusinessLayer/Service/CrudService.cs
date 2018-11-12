using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public interface CrudService<T>
    {
        bool Save(T t);
        bool Update(T t);
        bool Delete(T t);
        List<T> FindAll();
        T FindById(int? id);
    }
}
