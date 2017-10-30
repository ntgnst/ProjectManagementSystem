using System;
using System.Collections.Generic;

namespace PMS.Data.Models
{
    public partial class File
    {
        public int Id { get; set; }
        public string FilePath { get; set; }
        public int IssueId { get; set; }
        public int UserId { get; set; }
        public DateTime UploadDate { get; set; }

        public Issue Issue { get; set; }
        public User User { get; set; }
    }
}
