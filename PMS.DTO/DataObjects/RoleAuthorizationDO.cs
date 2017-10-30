using System;
using System.Collections.Generic;
using System.Text;

namespace PMS.DTO.DataObjects
{
    public class RoleAuthorizationDO
    {
        public int RoleId { get; set; }
        public int AuthorizationId { get; set; }

        public AuthDO AuthorizationDO { get; set; }
        public RoleDO RoleDO { get; set; }
    }
}
