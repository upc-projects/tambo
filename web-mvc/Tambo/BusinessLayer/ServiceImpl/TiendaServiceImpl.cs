using BusinessLayer.Service;
using DataLayer;
using DataLayer.Repository;
using DataLayer.RepositoryImpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ServiceImpl
{
    public class TiendaServiceImpl : TiendaService
    {

        private ITiendaRepository tiendaRepository;

        public TiendaServiceImpl()
        {
            tiendaRepository = new TiendaRepositoryImpl();
        }

        public bool Delete(Tienda t)
        {
            return tiendaRepository.Delete(t);
        }

        public List<Tienda> FindAll()
        {
            return tiendaRepository.FindAll();
        }

        public Tienda FindById(int? id)
        {
            return tiendaRepository.FindById(id);
        }

        public bool Save(Tienda t)
        {
            return tiendaRepository.Save(t);
        }

        public bool Update(Tienda t)
        {
            return tiendaRepository.Update(t);
        }
    }
}
