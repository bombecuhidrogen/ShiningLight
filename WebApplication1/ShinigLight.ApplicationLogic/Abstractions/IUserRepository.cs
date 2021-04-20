using ShinigLight.ApplicationLogic.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShinigLight.ApplicationLogic.Abstractions
{
    public interface IUserRepository : IRepository<User>
    {
        User GetUserById(Guid id);
    }
}
