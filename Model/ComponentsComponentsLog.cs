using System;
using System.Collections.Generic;

namespace Model
{
    public partial class ComponentsComponentsLog
    {
        public int ComponentId { get; set; }
        public int ComponentsLogId { get; set; }

        public virtual Component Component { get; set; } = null!;
        public virtual ComponentsLog ComponentsLog { get; set; } = null!;
    }
}
