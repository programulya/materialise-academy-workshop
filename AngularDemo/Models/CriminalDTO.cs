using System;

namespace AngularDemo.Models
{
    public class CriminalDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Reward { get; set; }
    }
}