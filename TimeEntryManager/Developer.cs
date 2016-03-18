using System.Collections.Generic;

namespace TimeEntryManager
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Developer : DbContext
    {
        public int DevId { get; set; }
        public string FullName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public string Email { get; set; }

        // Your context has been configured to use a 'Developer' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'TimeEntryManager.Developer' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Developer' 
        // connection string in the application configuration file.
        public Developer()
            : base("name=Developer")
        {
        }

        
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}