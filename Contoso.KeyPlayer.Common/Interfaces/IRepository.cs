using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.KeyPlayer.Common.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<ICollection<TEntity>> GetAsync();
        Task<TEntity> GetByIdAsync(int id);
    }
}
