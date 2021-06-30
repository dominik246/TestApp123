using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp123.Core.BaseTypes;
using TestApp123.Core.Entities;
using TestApp123.Core.Mappings;
using TestApp123.Core.Pocos;
using TestApp123.Core.Repository;

namespace TestApp123.Core.Service
{
    public class UserService : IUserService
    {
        private IUnitOfWork _uow;
        public UserService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task<List<IUserPoco>> GetAllUsersAsync()
        {
            var repo = _uow.GetRepository<IGenericRepository<UserEntity, IBaseFilterModel>>();
            var result = await repo.FindAsync(default);
            return result.Select(p => p.Map()).ToList();
        }
    }
}
