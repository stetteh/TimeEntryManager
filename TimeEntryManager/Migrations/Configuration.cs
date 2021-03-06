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
            var lucky = new Developer()
            {
                Email = "lucky@test.com",
                FirstName = "Lucky",
                LastName = "Smith",
                Title = "App Developer",
                StartDate = new DateTime(2016, 02, 01)
            };

            context.Developers.AddOrUpdate(
              d => new { d.FirstName, d.LastName },
              seth, daniel
               );

            var backend = new Group() { Name = "BackEnd" };
            backend.Developers.Add(daniel);
            backend.Developers.Add(seth);

            var frontend = new Group() { Name = "FrontEnd" };
            frontend.Developers.Add(seth);
            frontend.Developers.Add(lucky);

            context.Groups.AddOrUpdate(g => g.Name,
                backend, frontend
            );

            var ironyardClient = new Client() { Name = "The Iron Yard" };


            var project1 = new Project() {Name = "Update Website", Client = ironyardClient, Developers = {daniel, seth}};
            context.Projects.AddOrUpdate(p => p.Name,
              project1
              );
            var project2 = new Project() {Name = "Update Mobile App", Client = ironyardClient, Developers = {seth, lucky}};
             context.Projects.AddOrUpdate(p => p.Name,
             project2
             );


            var comment = new IndustryComment() { Comments = "Education is a fascinating industry, glad to have multiple player"};
            var eindustry1 = new Industry() { Name = "Education", IndustryComments = { comment } };


            context.Industries.AddOrUpdate(i => i.Name,
                eindustry1
            );
            var newtime = new TimeEntry() {Date = new DateTime(2016, 01, 10), TimeSpent = 10.5f, Developer = seth, Task = new Task() { Name = "Create footer", Project = project1 } };
            var newtime1 = new TimeEntry() { Date = new DateTime(2016, 01, 11), TimeSpent = 5.50f, Developer = seth, Task = new Task() { Name = "Create header", Project = project1 } };
            var newtime2 = new TimeEntry() { Date = new DateTime(2016, 01, 10), TimeSpent = 2.5f, Developer = lucky, Task = new Task() { Name = "Create Nav Bar", Project = project1 } };
            var newtime3 = new TimeEntry() { Date = new DateTime(2016, 01, 15), TimeSpent = 20f, Developer = lucky, Task = new Task() { Name = "new wire frame", Project = project2 } };
            var newtime4 = new TimeEntry() { Date = new DateTime(2016, 01, 16), TimeSpent = 10.5f, Developer = daniel, Task = new Task() { Name = "update login", Project = project2 } };


            context.TimeEntries.AddOrUpdate(p=>p.Date, newtime, newtime2, newtime1, newtime3, newtime4);
          

          
            context.IndustryComments.AddOrUpdate(c => c.Comments,
                comment
            );

            



        }
    }
}
