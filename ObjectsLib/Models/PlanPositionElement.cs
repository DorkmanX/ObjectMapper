namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class PlanPositionElement
    {
        public int Id { get; set; }
        public int PlanPositionId { get; set; }
        public int PartId { get; set; }
        public int? Quantity { get; set; }
        public string StCfg { get; set; }

        public virtual Part Part { get; set; }
        public virtual PlanPosition PlanPosition { get; set; }
    }
}
