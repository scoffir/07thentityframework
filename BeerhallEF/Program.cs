using BeerhallEF.Data;
using BeerhallEF.Models;
using System;

namespace BeerhallEF
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new ApplicationDbContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            Console.WriteLine("Database created");

            var b = new Brewer
            {
                Name = "Brewer2C1",
                StreetAddress = "V. Vaerwyckweg 1",
                DateEstablished = DateTime.Now.AddYears(-10),
                Turnover = 35000
            };

            var beer = new Beer
            {
                Name = "Orval",
                HasAlcohol = true
            };

            b.Beers.Add(beer);
            context.Brewers.Add(b);
            b.Turnover = 50000;
            context.SaveChanges();

           


        }
        }
    }
