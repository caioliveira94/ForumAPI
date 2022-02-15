using ForumApi.ApplicationService.Interfaces;
using ForumApi.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace ForumApi.ApplicationService.Services
{
    public class UserService : IUserService
    {
        public Task<bool> Create(string user, string password, string operatorName)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
