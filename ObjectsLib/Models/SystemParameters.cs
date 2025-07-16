using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class SystemParameters
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public int? TypeId { get; set; }
        public bool? ReadOnly { get; set; }
        public bool? Hidden { get; set; }

        public virtual SystemParameterType Type { get; set; }
    }
}
