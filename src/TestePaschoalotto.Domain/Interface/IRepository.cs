using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestePaschoalotto.Domain.Model;

namespace TestePaschoalotto.Domain.Interface
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        Task<TEntity> Create(TEntity entity);
        Task<TEntity> Update(TEntity entity);
        Task<List<TEntity>> GetAll();
    }
}
