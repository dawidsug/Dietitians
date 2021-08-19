using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class CommentsSeed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Comments.Any()) return;
            
            var comments = new List<Comment>
            {
                new Comment
                {
                    Description = "Fantastic visit!",
                    CommentForeignKey = "f5a29b47-b61e-40d1-89ff-3289ff607927"
                    //Rated = (Dietitian)context.Dietitians.First()
                    //Author
                },
                new Comment
                {
                    Description = "Fantastic dietetic!",
                    CommentForeignKey = "f5a29b47-b61e-40d1-89ff-3289ff607927"
                    //Rated = (Dietitian)context.Dietitians.Find(Guid.Parse("72BE901A-B1D0-4DE4-A82B-346CC108AA3B"))
                    //Author
                },
                new Comment
                {
                    Description = "Great! ",
                    CommentForeignKey = "f5a29b47-b61e-40d1-89ff-3289ff607927"
                    //Rated
                    //Author
                },
                new Comment
                {
                    Description = "Terrible man!",
                    CommentForeignKey = "f5a29b47-b61e-40d1-89ff-3289ff607927"
                    //Rated
                    //Author
                },
                new Comment
                {
                    Description = "That was mistake!",
                    CommentForeignKey = "f5a29b47-b61e-40d1-89ff-3289ff607927"
                    //Rated
                    //Author
                },
                new Comment
                {
                    Description = "OK",
                    CommentForeignKey = "f5a29b47-b61e-40d1-89ff-3289ff607927"
                    //Rated
                    //Author
                }
            };

            await context.Comments.AddRangeAsync(comments);
            await context.SaveChangesAsync();
        }
    }
}