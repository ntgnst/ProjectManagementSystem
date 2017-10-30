using System;
using System.Collections.Generic;
using System.Text;

namespace PMS.DTO.DataObjects
{
    public class NotificationDO
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public bool? IsRead { get; set; }

        public UserDO UserDO { get; set; }
    }
}
