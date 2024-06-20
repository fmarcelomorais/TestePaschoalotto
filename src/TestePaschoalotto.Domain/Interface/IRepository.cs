using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestePaschoalotto.Domain.Model;

namespace TestePaschoalotto.Domain.Interface
{
    public interface IRepository<TEntity> 
    {
        Task<TEntity> Create(TEntity entity);
        Task<TEntity> Update(TEntity entity);
        Task<List<TEntity>> GetAll();
        Task<TEntity> Find(Expression<Func<TEntity, bool>> expression);
    }
}
