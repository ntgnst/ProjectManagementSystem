using System;
using System.Collections.Generic;

namespace PMS.Data.Models
{
    public partial class Notification
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public bool? IsRead { get; set; }

        public User User { get; set; }
    }
}
