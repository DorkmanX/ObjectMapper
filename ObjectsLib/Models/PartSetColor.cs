using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPull.Objects.EntityFrameworkCore
{
    public class PartSetColor
    {
        public int ID { get; set; }
        public int PartSetID { get; set; }
        public int PartID { get; set; }
        public string Color { get; set; }

        public virtual PartSet PartSet { get; set; }
    }
}
