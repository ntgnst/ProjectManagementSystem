using System;
using System.Collections.Generic;
using System.Text;

namespace PMS.DTO.DataObjects
{
    public class FileDO
    {
        public int Id { get; set; }
        public string FilePath { get; set; }
        public int IssueId { get; set; }
        public int UserId { get; set; }
        public DateTime UploadDate { get; set; }

        public IssueDO IssueDO { get; set; }
        public UserDO UserDO { get; set; }
    }
}
