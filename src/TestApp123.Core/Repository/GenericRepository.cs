using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestApp123.Core.BaseTypes;
using TestApp123.Core.DAL;

namespace TestApp123.Core.Repository
{
    public class GenericRepository<T, U> : IGenericRepository<T, U> where T : BaseEntityModel where U : IBaseFilterModel
    {
        private Context _db;
        private DbSet<T> _entity;

        public GenericRepository(Context db)
        {
            _db = db;
            _entity = _db.Set<T>();
        }

        public async Task<List<T>> FindAsync(U filter)
        {
            return await _entity.ToListAsync();
        }
    }
}
