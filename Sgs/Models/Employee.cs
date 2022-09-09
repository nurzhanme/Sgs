using System;

namespace Sgs.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Shop Shop { get; set; }
    }
}
