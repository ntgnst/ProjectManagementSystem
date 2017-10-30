using System;
using System.Collections.Generic;

namespace PMS.Data.Models
{
    public partial class Comment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int IssueId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public Issue Issue { get; set; }
        public User User { get; set; }
    }
}
