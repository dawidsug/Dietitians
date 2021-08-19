using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class DietitiansSeed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Dietitians.Any()) return;
            
            var dietitians = new List<Dietitian>
            {
                new Dietitian
                {
                    FirstName = "Uncle",
                    LastName = "Bob",
                    Description = "The best dietitan.",
                    EmailAddress = "unclebob@bob.com",
                    PhoneNumber = "123123123",
                    Like = 150,
                    Unlike = 2,
                    DateOfJoining = DateTime.Now.AddMonths(-1),
                    //Comments
                },
                new Dietitian
                {
                    FirstName = "Bryan",
                    LastName = "Check",
                    Description = "The best dietitan.",
                    EmailAddress = "bryancheck@bryan.com",
                    PhoneNumber = "456456456",
                    Like = 73,
                    Unlike = 14,
                    DateOfJoining = DateTime.Now.AddMonths(-6),
                    //Comments
                },
                new Dietitian
                {
                    FirstName = "Karl",
                    LastName = "Mickelson",
                    Description = "The best dietitan.",
                    EmailAddress = "carlmickelson@mickelson.com",
                    PhoneNumber = "789789789",
                    Like = 36,
                    Unlike = 1,
                    DateOfJoining = DateTime.Now.AddMonths(-3),
                    //Comments
                },
                new Dietitian
                {
                    FirstName = "Allison",
                    LastName = "Grey",
                    Description = "The best dietitan.",
                    EmailAddress = "allisongrey@grey.com",
                    PhoneNumber = "741741741",
                    Like = 654,
                    Unlike = 96,
                    DateOfJoining = DateTime.Now.AddMonths(-7),
                    //Comments
                }
            };

            await context.Dietitians.AddRangeAsync(dietitians);
            await context.SaveChangesAsync();
        }
    }
}