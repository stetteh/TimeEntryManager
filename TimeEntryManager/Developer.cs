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

        public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
    }
}