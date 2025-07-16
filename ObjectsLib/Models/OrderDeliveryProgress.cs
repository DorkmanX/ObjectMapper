using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPull.Objects.EntityFrameworkCore
{
    public class OrderDeliveryProgress
    {
        public int ID { get; set; }
        public int PartId { get; set; }
        public string PlanNumber { get; set; }
        public int PlaceId { get; set; }
        public int FullQtyForPlanToDeliver {  get; set; }
        public int QtyAlreadyDelivered { get; set; }
        public int QtyForStart { get; set; }
    }
}
