using ShinigLight.ApplicationLogic.Abstractions;
using ShinigLight.ApplicationLogic.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShiningLight.DataAccess
{
    public class UsersRepository : BaseRepository<User>, IUserRepository
    {
        public UsersRepository(ShiningLightDBContext dbContext) : base(dbContext)
        {

        }

        public User GetUserById(Guid userGuid)
        {
            return dbContext.Users.Where(user => user.ID == userGuid).SingleOrDefault();
        }
    }
}
