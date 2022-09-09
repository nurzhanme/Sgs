using System;

namespace Sgs.Models
{
    public class Shop
    {
        public Guid Id { get; set; }
        public City City { get; set; }
        public string Title { get; set; }
    }
}
