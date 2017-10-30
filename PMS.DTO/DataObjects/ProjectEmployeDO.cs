using System;
using System.Collections.Generic;
using System.Text;

namespace PMS.DTO.DataObjects
{
    public class ProjectEmployeDO
    {
        public int ProjectId { get; set; }
        public int UserId { get; set; }

        public ProjectDO ProjectDO { get; set; }
        public UserDO UserDO { get; set; }
    }
}
