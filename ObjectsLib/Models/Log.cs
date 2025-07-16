using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class Log
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int SourceAppId { get; set; }
        public DateTime TimeStamp { get; set; }
        public int TypeId { get; set; }
        public string Rfu { get; set; }
        public int? ReferenceId { get; set; }
        public string TableName { get; set; }
        public int? UserId { get; set; }
        public int? LevelId { get; set; }

        public virtual LogLevel Level { get; set; }
        public virtual SourceApp SourceApp { get; set; }
        public virtual LogType Type { get; set; }
        public virtual User User { get; set; }
    }
}
