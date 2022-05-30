using System;
using System.Collections.Generic;

namespace Model
{
    public partial class Provider
    {
        public Provider()
        {
            ComponentsLogs = new HashSet<ComponentsLog>();
        }

        public int Id { get; set; }
        public string ProviderName { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<ComponentsLog> ComponentsLogs { get; set; }
    }
}
