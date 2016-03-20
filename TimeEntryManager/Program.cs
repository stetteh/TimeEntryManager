using System;
using System.Linq;

namespace TimeEntryManager
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var db = new TimeEntryDbContext();

            var brian = db.Developers.FirstOrDefault(x => x.FirstName == "Brian");


            if (brian == null)
            {
                brian = new Developer
                {
                    FirstName = "Brian",
                    LastName = "Stickney",
                    Title = "Developer",
                    StartDate = new DateTime(2016, 02, 01),
                    Email = "brian@test.com"
                };

                db.Developers.Add(brian);
            }

            brian.Title = "Some New Title";

            db.SaveChanges();

            foreach (var d in db.Developers)
            {
                Console.WriteLine($"{d.FirstName} {d.LastName}, {d.Title}, {d.Email}, {d.StartDate.ToShortDateString()}");
            }

            foreach (var d in db.Projects)
            {
                Console.WriteLine($"Project Name: {d.Name}");
            }

            foreach (var d in db.Clients)
            {
                Console.WriteLine($"{d.Name} is the Client");
            }

            foreach (var d in db.Industries)
            {
                Console.WriteLine($"{d.Name} is the industry");
            }

            foreach (var d in db.Groups)
            {
                Console.WriteLine($"Group is {d.Name}");
            }

            //foreach (var te in db.TimeEntries)
            //{
                
            //}

            Console.ReadLine();
        }
    }
}