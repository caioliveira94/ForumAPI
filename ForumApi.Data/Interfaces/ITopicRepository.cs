using ForumApi.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ForumApi.Data.Interfaces
{
    public interface ITopicRepository
    {
        public Task<List<Topic>> GetAll();
        public Task<Topic> GetById(int id);
        public Task<bool> Create(Topic topic);
        public Task<bool> Delete(int id);
        public Task<bool> Update(Topic topic);

    }
}
