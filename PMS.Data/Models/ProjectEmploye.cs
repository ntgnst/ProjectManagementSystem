using System;
using System.Collections.Generic;

namespace PMS.Data.Models
{
    public partial class ProjectEmploye
    {
        public int ProjectId { get; set; }
        public int UserId { get; set; }

        public Project Project { get; set; }
        public User User { get; set; }
    }
}
