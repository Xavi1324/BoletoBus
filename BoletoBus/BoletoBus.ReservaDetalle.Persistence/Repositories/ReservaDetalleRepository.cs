using BoletoBus.ReservaDetalle.Domain.Interfaces;
using BoletoBus.ReservaDetalle.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BoletoBus.Entities.Persistence.Repositories
{
    public class ReservaDetalleRepository : IReservaDetalleRepository
    {
        public void Delete(ReservaDetalle.Domain.Entities.ReservaDetalle entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<ReservaDetalle.Domain.Entities.ReservaDetalle, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ReservaDetalle.Domain.Entities.ReservaDetalle> GetAll()
        {
            throw new NotImplementedException();
        }

        public ReservaDetalle.Domain.Entities.ReservaDetalle GetEntityBy(int Id)
        {
            throw new NotImplementedException();
        }

        public List<ReservaDetalle.Domain.Entities.ReservaDetalle> GetReservaDetallesByIdReservaDetalle(int IdReservaDetalle)
        {
            throw new NotImplementedException();
        }

        public void Save(ReservaDetalle.Domain.Entities.ReservaDetalle entity)
        {
            throw new NotImplementedException();
        }

        public void Updater(ReservaDetalle.Domain.Entities.ReservaDetalle entity)
        {
            throw new NotImplementedException();
        }
    }
}
