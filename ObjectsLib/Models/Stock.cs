using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class Stock
    {
        public Stock()
        {
            Depot = new HashSet<Depot>();
            Place = new HashSet<Place>();
            PullOrder = new HashSet<PullOrder>();
            StockEntry = new HashSet<StockEntry>();
            TransferDestinationStock = new HashSet<Transfer>();
            TransferSourceStock = new HashSet<Transfer>();
            Vehicle = new HashSet<Vehicle>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Depot> Depot { get; set; }
        public virtual ICollection<Place> Place { get; set; }
        public virtual ICollection<PullOrder> PullOrder { get; set; }
        public virtual ICollection<StockEntry> StockEntry { get; set; }
        public virtual ICollection<Transfer> TransferDestinationStock { get; set; }
        public virtual ICollection<Transfer> TransferSourceStock { get; set; }
        public virtual ICollection<Vehicle> Vehicle { get; set; }
    }
}
