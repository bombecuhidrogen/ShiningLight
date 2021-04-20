using ShinigLight.ApplicationLogic.Abstractions;
using ShinigLight.ApplicationLogic.DataModels;
using ShinigLight.ApplicationLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShinigLight.ApplicationLogic.Services
{
    public class UsersService
    {
        private IUserRepository userRepository;
        public UsersService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public User GetUserById(string userId)
        {
            Guid userGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userGuid))
                throw new Exception("Invalid guid format");
            var user = userRepository.GetUserById(userGuid);
            if (user == null)
                throw new EntityNotFoundException(userGuid);
            return user;
        }
    }
}
