using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class BufferHP
    {
        public int ID { get; set; }
        public string PartCode { get; set; }
        public string Location { get; set; }
        public bool Status { get; set; }
        
    }
}
