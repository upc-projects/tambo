using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities_Layer;

namespace DataLayer.Repository
{
    public interface IProductoRepository : CrudRepository<Productos>
    {
        List<Productos> findByNombre(string name);
        List<Productos> findByMarca(Marcas marcas);
    }
}
