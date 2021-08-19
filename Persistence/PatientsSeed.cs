using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class PatientsSeed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Patients.Any()) return;
            
            var patients = new List<Patient>
            {
                new Patient
                {
                    FirstName = "Camila",
                    LastName = "Brat",
                    Description = "The best dietitan.",
                    EmailAddress = "camilabrat@brat.com",
                    PhoneNumber = "326326326",
                    //RecommendedDietitians = DietitiansSeed.Equals(),
                    //NonRecommendedDietitians,
                    DateOfJoining = DateTime.Now.AddMonths(-9),
                    //Comments
                },
                new Patient
                {
                    FirstName = "Jasmine",
                    LastName = "Young",
                    Description = "The best dietitan.",
                    EmailAddress = "jasmineyoung@young.com",
                    PhoneNumber = "986986986",
                    //RecommendedDietitians = DietitiansSeed.Equals(),
                    //NonRecommendedDietitians,
                    DateOfJoining = DateTime.Now.AddMonths(-3),
                    //Comments
                },
                new Patient
                {
                    FirstName = "Mark",
                    LastName = "Kane",
                    Description = "The best dietitan.",
                    EmailAddress = "markkane@kane.com",
                    PhoneNumber = "754754754",
                    //RecommendedDietitians = DietitiansSeed.Equals(),
                    //NonRecommendedDietitians,
                    DateOfJoining = DateTime.Now.AddMonths(-4),
                    //Comments
                },
                new Patient
                {
                    FirstName = "Garry",
                    LastName = "Pen",
                    Description = "The best dietitan.",
                    EmailAddress = "garrypen@pen.com",
                    PhoneNumber = "358358358",
                    //RecommendedDietitians = DietitiansSeed.Equals(),
                    //NonRecommendedDietitians,
                    DateOfJoining = DateTime.Now.AddMonths(-6),
                    //Comments
                },
            };

            await context.Patients.AddRangeAsync(patients);
            await context.SaveChangesAsync();
        }
    }
}