using System;

namespace Domain
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public Dietitian Rated { get; set; }
        public Patient Author { get; set; }
    }
}