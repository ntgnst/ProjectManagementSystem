using System;
using System.Collections.Generic;
using System.Text;

namespace PMS.DTO.DataObjects
{
    public class ProjectDO
    {
        public ProjectDO()
        {
            IssueDOList = new List<IssueDO>();
            ProjectEmployeDOList = new List<ProjectEmployeDO>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CreatedUserId { get; set; }

        public UserDO CreatedUserDO { get; set; }
        public List<IssueDO> IssueDOList { get; set; }
        public List<ProjectEmployeDO> ProjectEmployeDOList { get; set; }
    }
}
