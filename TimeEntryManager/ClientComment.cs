using System.Collections.Generic;

namespace TimeEntryManager
{
    public class ClientComment
    {
        public int Id { get; set; }
        public string Comments { get; set; }

        public virtual Developer Developer { get; set; }
        public virtual Client Client { get; set; }
    }

    public class ProjectComment
    {
        public int Id { get; set; }
        public string Comments { get; set; }

        public virtual Developer Developer { get; set; }
        public virtual Project Project { get; set; }

    }

    public class IndustryComment
    {
        public int Id { get; set; }
        public string Comments { get; set; }

        public virtual  Developer  Developer { get; set; }
        public virtual Industry Industry { get; set; }

    }
}