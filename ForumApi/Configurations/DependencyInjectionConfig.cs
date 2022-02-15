using ForumApi.ApplicationService.Interfaces;
using ForumApi.ApplicationService.Services;
using ForumApi.Data.Interfaces;
using ForumApi.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace ForumApi.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            #region Repositories
            services.AddScoped(typeof(IUserRepository), typeof(UserRepository));
            services.AddScoped(typeof(ITopicRepository), typeof(TopicRepository));
            #endregion

            #region Services
            services.AddScoped(typeof(IUserService), typeof(UserService));
            services.AddScoped(typeof(ITopicService), typeof(TopicService));
            #endregion
        }
    }
}
