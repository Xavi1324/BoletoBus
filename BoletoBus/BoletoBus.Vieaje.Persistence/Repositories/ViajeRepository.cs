
using BoletoBus.Viaje.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BoletoBus.Entities.Persistence.Repositories
{
    public class ViajeRepository : IViajeRepository
    {
        public void Delete(Viaje.Domain.Entities.Viaje entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<Viaje.Domain.Entities.Viaje, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Viaje.Domain.Entities.Viaje> GetAll()
        {
            throw new NotImplementedException();
        }

        public Viaje.Domain.Entities.Viaje GetEntityBy(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Viaje.Domain.Entities.Viaje> GetViajesByIdViaje(int IdViaje)
        {
            throw new NotImplementedException();
        }

        public void Save(Viaje.Domain.Entities.Viaje entity)
        {
            throw new NotImplementedException();
        }

        public void Updater(Viaje.Domain.Entities.Viaje entity)
        {
            throw new NotImplementedException();
        }
    }
}
