using System;
using System.Collections.Generic;
using System.Text;

namespace PMS.DTO.DataObjects
{
    public class AuthDO
    {
        public AuthDO()
        {
            RoleAuthorizationDOList = new List<RoleAuthorizationDO>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public List<RoleAuthorizationDO> RoleAuthorizationDOList { get; set; }
    }
}
