using System;

namespace ForumApi.Models
{
    public class TopicModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Creator { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
