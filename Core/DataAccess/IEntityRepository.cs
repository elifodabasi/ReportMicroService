using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
   public interface IEntityRepository<TEntity> where TEntity: class, IEntity, new() 
    {
        void Add(TEntity entity);
        TEntity Find(Expression<Func<TEntity, bool>> predicate);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate = null);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
