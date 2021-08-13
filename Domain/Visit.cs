using System;

namespace Domain
{
    public class Visit
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool Type { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string PostalCode { get; set; }
        public Dietitian Dietitian { get; set; }
        public Patient Patient { get; set; }
        public bool Visited { get; set; }
    }
}