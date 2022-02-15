using ForumApi.ApplicationService.Interfaces;
using ForumApi.Data.Interfaces;
using ForumApi.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ForumApi.ApplicationService.Services
{
    public class TopicService : ITopicService
    {
        private readonly ITopicRepository _topicRepository;

        public TopicService(ITopicRepository topicRepository)
        {
            _topicRepository = topicRepository;
        }

        public async Task<bool> Create(Topic topic)
        {
            return await _topicRepository.Create(topic);
        }

        public async Task<bool> Delete(int id)
        {
            return await _topicRepository.Delete(id);
        }

        public async Task<List<Topic>> GetAll()
        {
            return await _topicRepository.GetAll();
        }

        public async Task<Topic> GetById(int id)
        {
            return await _topicRepository.GetById(id);
        }

        public async Task<bool> Update(Topic topic)
        {
            return await _topicRepository.Update(topic);
        }
    }
}
