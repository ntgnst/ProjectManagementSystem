using System;
using System.Collections.Generic;
using System.Text;

namespace PMS.DTO.DataObjects
{
    public class CommentDO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int IssueId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public IssueDO IssueDO { get; set; }
        public UserDO UserDO { get; set; }
    }
}
