using System;
using System.Collections.Generic;

namespace PMS.Data.Models
{
    public partial class Priority
    {
        public Priority()
        {
            Issue = new HashSet<Issue>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }

        public ICollection<Issue> Issue { get; set; }
    }
}
