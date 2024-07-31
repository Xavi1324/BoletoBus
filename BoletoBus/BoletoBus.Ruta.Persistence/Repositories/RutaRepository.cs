
using BoletoBus.Ruta.Domain.Entities;
using BoletoBus.Ruta.Domain.Interfaces;
using BoletoBus.Ruta.Persistence.Context;
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
        private readonly BoletosBusContext context;
        public RutaRepository(BoletosBusContext context)
        {
            this.context = context;
        }

        public bool Exists(Expression<Func<Ruta.Domain.Entities.Ruta, bool>> filter)
        {
            return this.context.Ruta.Any(filter);
        }

        public List<Ruta.Domain.Entities.Ruta> GetAll()
        {
            return this.context.Ruta.Select(ru => new Ruta.Domain.Entities.Ruta()
            {
                IdRuta = ru.IdRuta,
                Origen = ru.Origen,
                Destino = ru.Destino,
                FechaCreacion = ru.FechaCreacion,
            }).ToList();
        }

        public Ruta.Domain.Entities.Ruta GetEntityBy(int Id)
        {
            var Ruta = this.context.Ruta.Find(Id);
            Ruta.Domain.Entities.Ruta ruta = new Ruta.Domain.Entities.Ruta()
            {
                IdRuta = Ruta.IdRuta,
                Origen = Ruta.Origen,
                Destino = Ruta.Destino,
                FechaCreacion = Ruta.FechaCreacion,
            };
            return ruta;
        }

        public List<Ruta.Domain.Entities.Ruta> GetRutasByIdRuta(int IdRuta)
        {
            return this.context.Ruta.Where(r => r.IdRuta == IdRuta).ToList();
        }

        public void Save(Ruta.Domain.Entities.Ruta entity)
        {
            Ruta.Domain.Entities.Ruta ruta = new Ruta.Domain.Entities.Ruta()
            {
                Origen = entity.Origen,
                Destino = entity.Destino,
                FechaCreacion = entity.FechaCreacion,
            };
            this.context.Ruta.Add(ruta);
            this.context.SaveChanges();
        }

        public void Updater(Ruta.Domain.Entities.Ruta entity)
        {
            Ruta.Domain.Entities.Ruta rutaUpdate = this.context.Ruta.Find(entity.IdRuta);
            rutaUpdate.IdRuta = entity.IdRuta;
            rutaUpdate.Origen = entity.Origen;
            rutaUpdate.Destino = entity.Destino;
            rutaUpdate.FechaCreacion = entity.FechaCreacion;
            this.context.Ruta.Update(rutaUpdate);
            this.context.SaveChanges();
        }

        public void Delete(Ruta.Domain.Entities.Ruta entity)
        {
            context.Ruta.Remove(entity);
            context.SaveChanges();
        }
    }
    
}
