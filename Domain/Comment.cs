using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        
        public string CommentForeignKey { get; set; }
        //[ForeignKey("RatedId")]
        public Dietitian Rated { get; set; }
        //[ForeignKey("AuthorId")]
        public Patient Author { get; set; }
    }
}