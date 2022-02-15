using ForumApi.Data.Contexts;
using ForumApi.Data.Interfaces;
using ForumApi.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace ForumApi.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        protected readonly ApplicationDbContext _applicationDbContext;
        public UserRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

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
