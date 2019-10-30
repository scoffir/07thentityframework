using System;
using System.Collections.Generic;
using System.Text;

namespace BeerhallEF.Models
{
    public class Brewer
    {
        public int BrewerId { get; set; }
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public int? Turnover { get; set; }
        public DateTime DateEstablished { get; set; }
        public ICollection<Beer> Beers { get; set; }

        public Brewer()
        {
            Beers = new List<Beer>();
        }
    }
}
