using ForumApi.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ForumApi.ApplicationService.Interfaces
{
    public interface ITopicService
    {
        public Task<List<Topic>> GetAll();
        public Task<Topic> GetById(int id);
        public Task<bool> Create(Topic topic);
        public Task<bool> Delete(int id);
        public Task<bool> Update(Topic topic);
    }
}
