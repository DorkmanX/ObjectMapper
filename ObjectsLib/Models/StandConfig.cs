using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsLib.Models
{
    public class StandConfig
    {
        public int ID { get; set; }
        public int PlaceID { get; set; }
        public string ModelID { get; set; }
        public bool IsActive { get; set; }
    }
}
