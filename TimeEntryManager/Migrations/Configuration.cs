using System.ComponentModel.DataAnnotations;

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
            AutomaticMigrationDataLossAllowed = true;
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
            var eindustry1 = new Industry() {Name = "Education"};
            var comment = new IndustryComment() { Comments = "Education i s a fascinating industry, glad to have multiple player"};


           
            context.Developers.AddOrUpdate(
                d => new { d.FirstName, d.LastName },
                seth, daniel
                 );

            context.Projects.AddOrUpdate(p => p.Name,
                new Project() { Name = "Update Website", Client = ironyardClient, Developers = { daniel, seth } }
                );

            var backend = new Group() { Name = "BackEnd" };
            backend.Developers.Add(daniel);

            var frontend = new Group() { Name = "FrontEnd" };
            frontend.Developers.Add(seth);

            context.Groups.AddOrUpdate(g => g.Name,
                backend, frontend
            );

            context.Industries.AddOrUpdate(i => i.Name,
                new Industry() { Name = "Education"}
            );

            context.IndustryComments.AddOrUpdate(c => c.Comments,
                comment
            );




        }
    }
}
