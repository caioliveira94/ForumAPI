using AutoMapper;
using ForumApi.ApplicationService.Interfaces;
using ForumApi.Domain.Entities;
using ForumApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ForumApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TopicsController : ControllerBase
    {
        private readonly ILogger<TopicsController> _logger;
        private readonly ITopicService _topicService;
        private readonly IMapper _mapper;

        public TopicsController(ILogger<TopicsController> logger, ITopicService topicService, IMapper mapper)
        {
            _logger = logger;
            _topicService = topicService;
            _mapper = mapper;
        }

        [HttpGet("GetTopics")]
        public async Task<IEnumerable<TopicModel>> GetTopics()
        {
            var topics = await _topicService.GetAll();
            return _mapper.Map<List<TopicModel>>(topics);
        }

        [HttpGet]
        public async Task<TopicModel> Get([FromRoute] int id)
        {
            var topic = await _topicService.GetById(id);
            return _mapper.Map<TopicModel>(topic);
        }

        [HttpPost]
        public async Task<IActionResult> Create(TopicModel topic)
        {
            var newTopic = _mapper.Map<Topic>(topic);
            return Ok(await _topicService.Create(newTopic));
        }

        [HttpPut]
        public async Task<IActionResult> Update(TopicModel topic)
        {
            var updatedTopic = _mapper.Map<Topic>(topic);
            return Ok(await _topicService.Update(updatedTopic));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            return Ok(await _topicService.Delete(id));
        }
    }
}
