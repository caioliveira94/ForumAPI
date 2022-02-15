using AutoMapper;
using ForumApi.Domain.Entities;
using ForumApi.Models;

namespace DTM.WebAPI.AutoMapper
{
    public class ApiMapper : Profile
    {
        public ApiMapper()
        {
            CreateMap<TopicModel, Topic>().ReverseMap();
        }
    }
}
