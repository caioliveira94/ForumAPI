using ForumApi.Domain.Entities;
using System.Threading.Tasks;

namespace ForumApi.ApplicationService.Interfaces
{
    public interface IUserService
    {
        public Task<User> GetByUsername(string username);
        public Task<bool> Create(string user, string password, string operatorName);
        public Task<bool> Update(User user);
    }
}
