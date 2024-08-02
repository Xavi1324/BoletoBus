using BoletoBus.Viaje.Domain.Interfaces;
using BoletoBus.Viaje.Persistence.Context;
using System.Linq.Expressions;

namespace BoletoBus.Entities.Persistence.Repositories
{
    public class ViajeRepository : IViajeRepository
    {
        private readonly BoletosBusContext context;
        public ViajeRepository(BoletosBusContext context)
        {
            this.context = context;
        }

        public bool Exists(Expression<Func<Viaje.Domain.Entities.Viaje, bool>> filter)
        {
            return this.context.Viaje.Any(filter);
        }

        public List<Viaje.Domain.Entities.Viaje> GetAll()
        {
            return context.Viaje.ToList();
        }

        public Viaje.Domain.Entities.Viaje GetEntityBy(int Id)
        {
            return context.Viaje.Find(Id);
        }

        public List<Viaje.Domain.Entities.Viaje> GetViajesByIdViaje(int Id)
        {
            return this.context.Viaje.Where(V => V.id == Id).ToList();
        }

        public void Save(Viaje.Domain.Entities.Viaje entity)
        {
            try
            {
                this.context.Viaje.Add(entity);
                this.context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Error guardando viaje", ex);
            }
        }

        public void Updater(Viaje.Domain.Entities.Viaje entity)
        {
            try
            {
                this.context.Viaje.Update(entity);
                this.context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Error actualizando viaje", ex);
            }
        }

        public void Delete(Viaje.Domain.Entities.Viaje entity)
        {
            context.Viaje.Remove(entity);
            context.SaveChanges();
        }
    }
}
