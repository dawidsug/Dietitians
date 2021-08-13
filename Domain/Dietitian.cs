using System;
using System.Collections.Generic;

namespace Domain
{
    public class Dietitian
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public int Like { get; set; }
        public int Unlike { get; set; }
        public DateTime DateOfJoining { get; set; }
        public List<Comment> Comments { get; set; }
    }
}