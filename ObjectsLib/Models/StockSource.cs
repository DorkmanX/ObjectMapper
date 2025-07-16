using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class StockSource
    {
        public int Id { get; set; }
        public string Name { get; set; }
/*        public int Type { get; set; }*/

        public string SQLCmd { get; set; }
        public string Comment { get; set; }
    }
}
