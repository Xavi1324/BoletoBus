using BoletoBus.Ruta.Domain.Interfaces;
using BoletoBus.Ruta.Persistence.Context;
using System.Linq.Expressions;

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
            return context.Ruta.Any(filter);
        }

        public List<Ruta.Domain.Entities.Ruta> GetAll()
        {
            return context.Ruta.ToList();
            
        }

        public Ruta.Domain.Entities.Ruta GetEntityBy(int Id)
        {
           return context.Ruta.Find(Id);
            
        }

        public List<Ruta.Domain.Entities.Ruta> GetRutasByIdRuta(int Id)
        {
            return this.context.Ruta.Where(ru => ru.id == Id).ToList();
        }

        public void Save(Ruta.Domain.Entities.Ruta entity)
        {
            try
            {
                this.context.Ruta.Add(entity);
                this.context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Error saving route", ex);
            }
        }

        public void Updater(Ruta.Domain.Entities.Ruta entity)
        {
            try
            {
                this.context.Ruta.Update(entity);
                this.context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Error updating route", ex);
            }
            
        }

        public void Delete(Ruta.Domain.Entities.Ruta entity)
        {
            context.Ruta.Remove(entity);
            context.SaveChanges();
        }
    }
    
}
