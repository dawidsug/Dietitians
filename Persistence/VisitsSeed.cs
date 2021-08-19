using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class VisitsSeed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Visits.Any()) return;
            
            var visits = new List<Visit>
            {
                new Visit
                {
                    Name = "First visit",
                    Description = "First visit in our clinic.",
                    Date = DateTime.Now.AddMonths(+2),
                    Type = false,
                    City = "New York",
                    Street = "High Line",
                    Number = "78",
                    PostalCode = "456-782",
                    //Dietitian
                    //Patient
                    Visited = false
                },
                new Visit
                {
                    Name = "New Patient",
                    Description = "Welcome to our clinic.",
                    Date = DateTime.Now.AddMonths(+1),
                    Type = false,
                    City = "New York",
                    Street = "orchard Street",
                    Number = "63",
                    PostalCode = "968-478",
                    //Dietitian
                    //Patient
                    Visited = false
                },
                new Visit
                {
                    Name = "Dietetic interview",
                    Description = "Visit with dietetic interview.",
                    Date = DateTime.Now.AddMonths(+4),
                    Type = false,
                    City = "New York",
                    Street = "Bleecker Street",
                    Number = "456",
                    PostalCode = "775-659",
                    //Dietitian
                    //Patient
                    Visited = false
                },
                new Visit
                {
                    Name = "First visit",
                    Description = "First visit in our clinic.",
                    Date = DateTime.Now.AddMonths(-1),
                    Type = false,
                    City = "New York",
                    Street = "High Line",
                    Number = "369",
                    PostalCode = "456-782",
                    //Dietitian
                    //Patient
                    Visited = true
                },
            };

            await context.Visits.AddRangeAsync(visits);
            await context.SaveChangesAsync();
        }
    }
}