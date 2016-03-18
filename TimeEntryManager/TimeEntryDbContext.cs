using System.Data.Entity;

namespace TimeEntryManager
{
    public class TimeEntryDbContext : DbContext
    {
        // Your context has been configured to use a 'Developer' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'TimeEntryManager.Developer' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Developer' 
        // connection string in the application configuration file.
        public TimeEntryDbContext()
            : base("name=TimeEntryCS")
        {
        }


        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Developer> Developers { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
    }

   
}