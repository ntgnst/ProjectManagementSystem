using System;
using System.Collections.Generic;

namespace PMS.Data.Models
{
    public partial class RoleAuthorization
    {
        public int RoleId { get; set; }
        public int AuthorizationId { get; set; }

        public Auth Authorization { get; set; }
        public Role Role { get; set; }
    }
}
