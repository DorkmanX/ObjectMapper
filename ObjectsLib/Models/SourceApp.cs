using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class SourceApp
    {
        public SourceApp()
        {
            Log = new HashSet<Log>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Log> Log { get; set; }
    }
}
