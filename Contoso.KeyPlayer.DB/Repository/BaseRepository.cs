using Contoso.KeyPlayer.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.KeyPlayer.DB.Repository
{
    abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly KeyPlayerContext _context;
        private readonly DbSet<TEntity> _dbset;

        public BaseRepository(KeyPlayerContext context)
        {
            _context = context;
            _dbset = context.Set<TEntity>();
        }
        public async Task<ICollection<TEntity>> GetAsync()
        {
            return await _dbset.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbset.FindAsync(id);
        }
    }
}
