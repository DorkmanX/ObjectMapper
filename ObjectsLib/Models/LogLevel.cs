using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class LogLevel
    {
        public LogLevel()
        {
            Log = new HashSet<Log>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Log> Log { get; set; }
    }
}
