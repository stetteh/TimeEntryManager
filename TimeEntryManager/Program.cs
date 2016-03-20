﻿using System;
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

            Console.ReadLine();
        }
    }
}