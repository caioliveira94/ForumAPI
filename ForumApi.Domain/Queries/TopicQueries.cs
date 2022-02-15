using ForumApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ForumApi.Domain.Queries
{
    public static class TopicQueries
    {
        public static Expression<Func<Topic, bool>> GetById(int id)
        {
            return x => x.Id == id;
        }
    }
}
