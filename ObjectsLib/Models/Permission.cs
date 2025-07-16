using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class Permission
    {
        public Permission()
        {
            User = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Role { get; set; }
        public int Level { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
