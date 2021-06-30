using System.Collections.Generic;
using System.Threading.Tasks;
using TestApp123.Core.BaseTypes;

namespace TestApp123.Core.Repository
{
    public interface IGenericRepository<T, U>
        where T : BaseEntityModel
        where U : IBaseFilterModel
    {
        Task<List<T>> FindAsync(U filter);
    }
}