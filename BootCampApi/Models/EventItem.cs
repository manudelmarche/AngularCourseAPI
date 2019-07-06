using System;
using System.Collections.Generic;

namespace BootCampApi.Controllers
{
    public class EventItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageSrc { get; set; }

        public EventItem(int id, string naam, DateTime tijd, string beschrijving, double prijs, string source)
        {
            Id = id;
            Name = naam;
            Date = tijd;
            Description = beschrijving;
            Price = prijs;
            ImageSrc = source;
        }
    }
}
