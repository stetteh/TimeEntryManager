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
        public virtual ICollection<ClientComment> ClientComments { get; set; } = new List<ClientComment>();
        public virtual ICollection<ProjectComment> ProjectComments { get; set; } = new List<ProjectComment>();
        public virtual ICollection<IndustryComment> IndustryComments { get; set; } = new List<IndustryComment>();
    }

    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Developer> Developers { get; set; } = new List<Developer>();
        public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();

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

        public virtual Task Task { get; set; }
        public virtual Developer Developer { get; set; }
    }

    public class Industry
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Client> Clients { get; set; } = new List<Client>();
        public virtual ICollection<IndustryComment> IndustryComments { get; set; } = new List<IndustryComment>();
    }

    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
    }

}