using System;
using System.Collections.Generic;

namespace PMS.Data.Models
{
    public partial class Auth
    {
        public Auth()
        {
            RoleAuthorization = new HashSet<RoleAuthorization>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<RoleAuthorization> RoleAuthorization { get; set; }
    }
}
