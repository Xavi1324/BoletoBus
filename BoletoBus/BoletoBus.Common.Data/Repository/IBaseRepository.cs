using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BoletoBus.Common.Data.Repository
{
    public interface IBaseRepository<TEntity, TType> where TEntity : class
    {
        void Save(TEntity entity);
        void Updater(TEntity entity);
        void Delete(TEntity entity);
        List<TEntity> GetAll();
        TEntity GetEntityBy(TType Id);

        bool Exists(Expression<Func<TEntity, bool>> filter);
    }
}
