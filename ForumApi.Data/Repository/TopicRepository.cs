using ForumApi.Data.Contexts;
using ForumApi.Data.Interfaces;
using ForumApi.Domain.Entities;
using ForumApi.Domain.Queries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ForumApi.Data.Repository
{
    public class TopicRepository : ITopicRepository
    {
        protected readonly ApplicationDbContext _applicationDbContext;
        public TopicRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<bool> Create(Topic topic)
        {
            topic.CreationDate = DateTime.UtcNow;
            await _applicationDbContext.Topics.AddAsync(topic);
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var topic = GetById(id).Result;
            _applicationDbContext.Topics.Remove(topic);
            return true;
        }

        public async Task<List<Topic>> GetAll()
        {
            return await _applicationDbContext.Topics.ToListAsync();
        }

        public async Task<Topic> GetById(int id)
        {
            return await _applicationDbContext.Topics
                .FindAsync(TopicQueries.GetById(id));
        }

        public async Task<bool> Update(Topic topic)
        {
            _applicationDbContext.Topics.Update(topic);
            return true;
        }
    }
}
