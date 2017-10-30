using System;
using System.Collections.Generic;
using System.Text;

namespace PMS.DTO.DataObjects
{
    public class MessageDO
    {
        public int Id { get; set; }
        public string MessageContent { get; set; }
        public DateTime Date { get; set; }
        public int PostUserId { get; set; }
        public int GetUserId { get; set; }

        public UserDO GetUserDO { get; set; }
        public UserDO PostUserDO { get; set; }
    }
}
