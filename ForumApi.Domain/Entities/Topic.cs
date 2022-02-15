using System;

namespace ForumApi.Domain.Entities
{
    public class Topic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Creator { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
