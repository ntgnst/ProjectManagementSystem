using System;
using System.Collections.Generic;

namespace PMS.Data.Models
{
    public partial class Message
    {
        public int Id { get; set; }
        public string MessageContent { get; set; }
        public DateTime Date { get; set; }
        public int PostUserId { get; set; }
        public int GetUserId { get; set; }
        public User GetUser { get; set; }
        public User PostUser { get; set; }
    }
}
