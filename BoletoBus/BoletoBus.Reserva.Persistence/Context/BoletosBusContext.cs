

using Microsoft.EntityFrameworkCore;

namespace BoletoBus.Reserva.Persistence.Context
{
    public class BoletosBusContext : DbContext
    {
        #region "Constructor"
        public BoletosBusContext(DbContextOptions<BoletosBusContext> options) : base(options)   
        {
            
        }
        #endregion
        
        #region  "Db Sets"
        public DbSet<Domain.Entities.Reserva> Reserva { get; set; }
        public DbSet<Domain.Entities.ReservaDetalle> ReservaDetalle {get; set;}
        public DbSet<Domain.Entities.Ruta> Ruta {get; set;}
        public DbSet<Domain.Entities.Viaje> Viaje {get; set;}
        #endregion
    }
}
