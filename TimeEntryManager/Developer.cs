using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimeEntryManager
{
    public class Developer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Group> Groups { get; set; } = new List<Group>();
        public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
    }

    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Developer> Developers { get; set; } = new List<Developer>();

        public virtual Client Client { get; set; }
    }

    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Project> Projects { get; set; } = new List<Project>(); //maps to project class or project Id
        public virtual ICollection<Industry> Industries  { get; set; } = new List<Industry>();
    }

    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Developer> Developers { get; set; } = new List<Developer>();
    }

    public class TimeEntry
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public float TimeSpent { get; set; }

        public virtual Developer Developer { get; set; }
        public virtual Project Project { get; set; }
    }

    public class Industry
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Client> Clients { get; set; } = new List<Client>();
    }

}