
using BoletoBus.Ruta.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BoletoBus.Entities.Persistence.Repositories
{
    public class RutaRepository : IRutaRepository
    {
        public void Delete(Ruta.Domain.Entities.Ruta entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<Ruta.Domain.Entities.Ruta, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Ruta.Domain.Entities.Ruta> GetAll()
        {
            throw new NotImplementedException();
        }

        public Ruta.Domain.Entities.Ruta GetEntityBy(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Ruta.Domain.Entities.Ruta> GetRutasByIdRuta(int IdRuta)
        {
            throw new NotImplementedException();
        }

        public void Save(Ruta.Domain.Entities.Ruta entity)
        {
            throw new NotImplementedException();
        }

        public void Updater(Ruta.Domain.Entities.Ruta entity)
        {
            throw new NotImplementedException();
        }
    }
}
