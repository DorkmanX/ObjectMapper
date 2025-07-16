using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPull.Objects.EntityFrameworkCore
{
    public class WorkOrder
    {
        public int ID { get; set; }
        public string Parent { get; set; }
        public string ParentDescription { get; set; }
        public string BC { get; set; }
        public string OrdNrAEG { get; set; }
        public int OrdQty { get; set; }
        public string Child { get; set; }
        public string ChildDescription { get; set; }
        public int ChildQty { get; set; }
        public string DEF { get; set; }
        public int ProdQty { get; set; }
        public DateTime Timestamp { get; set; }
        public bool IsNewSnapshot { get; set; }
    }
}
