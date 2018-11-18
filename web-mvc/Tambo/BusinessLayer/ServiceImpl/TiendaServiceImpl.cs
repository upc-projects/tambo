using BusinessLayer.Service;
using DataLayer;
using DataLayer.Repository;
using DataLayer.RepositoryImpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities_Layer;

namespace BusinessLayer.ServiceImpl
{
    public class TiendaServiceImpl : TiendaService
    {

        private ITiendaRepository tiendaRepository;

        public TiendaServiceImpl()
        {
            tiendaRepository = new TiendaRepositoryImpl();
        }

        public bool Delete(Tiendas t)
        {
            return tiendaRepository.Delete(t);
        }

        public List<Tiendas> FindAll()
        {
            return tiendaRepository.FindAll();
        }

        public Tiendas FindById(int? id)
        {
            return tiendaRepository.FindById(id);
        }

        public bool Save(Tiendas t)
        {
            return tiendaRepository.Save(t);
        }

        public bool Update(Tiendas t)
        {
            return tiendaRepository.Update(t);
        }
    }
}
