

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
        
        public DbSet<ReservaDetalle.Domain.Entities.ReservaDetalle> ReservaDetalle {get; set;}
        
        #endregion
    }
}
