using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class SystemParameterType
    {
        public SystemParameterType()
        {
            SystemParameters = new HashSet<SystemParameters>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<SystemParameters> SystemParameters { get; set; }
    }
}
