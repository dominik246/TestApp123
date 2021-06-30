using System.Collections.Generic;
using System.Threading.Tasks;
using TestApp123.Core.Pocos;

namespace TestApp123.Core.Service
{
    public interface IUserService
    {
        Task<List<IUserPoco>> GetAllUsersAsync();
    }
}