using System;
using System.Collections.Generic;
using System.Text;
using TestApp123.Core.Entities;
using TestApp123.Core.Pocos;

namespace TestApp123.Core.Mappings
{
    public static class UserMappings
    {
        public static UserEntity Map(this IUserPoco poco)
        {
            return new UserEntity
            {
                Name = poco.Name,
                Id = poco.Id
            };
        }

        public static IUserPoco Map(this UserEntity entity)
        {
            return new UserPoco
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }
    }
}
