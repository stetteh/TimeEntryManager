namespace TimeEntryManager.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TimeEntryManager.TimeEntryDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TimeEntryManager.TimeEntryDbContext context)
        {
            var seth = new Developer()
            {
                Email = "seth@test.com",
                FirstName = "Seth",
                LastName = "Quaye",
                Title = "Senior Developer",
                StartDate = new DateTime(2016, 1, 1)
            };
            var daniel = new Developer()
            {
                Email = "daniel@test.com",
                FirstName = "Daniel",
                LastName = "Pollock",
                Title = "Junior Developer",
                StartDate = new DateTime(2014, 5, 1)
            };

            var ironyardClient = new Client() { Name = "The Iron Yard" };

            context.Developers.AddOrUpdate(
                d => new { d.FirstName, d.LastName },
                seth, daniel
                 );

            context.Projects.AddOrUpdate(p => p.Name,
                new Project() { Name = "Update Website", Client = ironyardClient, Developers = { daniel, seth } }
                );

        }
    }
}
