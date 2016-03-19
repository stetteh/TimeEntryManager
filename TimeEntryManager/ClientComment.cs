using System.Collections.Generic;

namespace TimeEntryManager
{
    public class ClientComment
    {
        public int Id { get; set; }
        public string Comments { get; set; }

        public virtual ICollection<Developer> Developers { get; set; } = new List<Developer>();
        public virtual ICollection<Client> Clients { get; set; } = new List<Client>();
    }

    public class ProjectComment
    {
        public int Id { get; set; }
        public string Comments { get; set; }

        public virtual ICollection<Developer> Developers { get; set; } = new List<Developer>();
        public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

    }

    public class IndustryComment
    {
        public int Id { get; set; }
        public string Comments { get; set; }

        public virtual ICollection<Developer> Developers { get; set; } = new List<Developer>();
        public virtual ICollection<Industry> Industries { get; set; } = new List<Industry>();

    }
}