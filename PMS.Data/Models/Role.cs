using System;
using System.Collections.Generic;

namespace PMS.Data.Models
{
    public partial class Role
    {
        public Role()
        {
            RoleAuthorization = new HashSet<RoleAuthorization>();
            User = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<RoleAuthorization> RoleAuthorization { get; set; }
        public ICollection<User> User { get; set; }
    }
}
