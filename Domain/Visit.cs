using System;
using System.ComponentModel.DataAnnotations.Schema;

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
        //[ForeignKey("DietitianId")]
        public Dietitian Dietitian { get; set; } = new Dietitian();
        //[ForeignKey("PatientId")]
        public Patient Patient { get; set; } = new Patient();
        public bool Visited { get; set; }
    }
}