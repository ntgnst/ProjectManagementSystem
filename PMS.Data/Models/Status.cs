using System;
using System.Collections.Generic;

namespace PMS.Data.Models
{
    public partial class Status
    {
        public Status()
        {
            Issue = new HashSet<Issue>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public short Priority { get; set; }

        public ICollection<Issue> Issue { get; set; }
    }
}
