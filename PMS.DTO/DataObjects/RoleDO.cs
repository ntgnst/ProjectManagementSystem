using System;
using System.Collections.Generic;
using System.Text;

namespace PMS.DTO.DataObjects
{
    public class RoleDO
    {
        public RoleDO()
        {
            RoleAuthorizationDOList = new List<RoleAuthorizationDO>();
            UserDOList = new List<UserDO>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public List<RoleAuthorizationDO> RoleAuthorizationDOList { get; set; }
        public List<UserDO> UserDOList { get; set; }
    }
}
