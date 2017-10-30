using System;
using System.Collections.Generic;

namespace PMS.Data.Models
{
    public partial class Project
    {
        public Project()
        {
            Issue = new HashSet<Issue>();
            ProjectEmploye = new HashSet<ProjectEmploye>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CreatedUserId { get; set; }

        public User CreatedUser { get; set; }
        public ICollection<Issue> Issue { get; set; }
        public ICollection<ProjectEmploye> ProjectEmploye { get; set; }
    }
}
