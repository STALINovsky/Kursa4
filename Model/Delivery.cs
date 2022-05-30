using System;
using System.Collections.Generic;

namespace Model
{
    public partial class Delivery
    {
        public Delivery()
        {
            ComponentsLogs = new HashSet<ComponentsLog>();
        }

        public int Id { get; set; }
        public string DeliveryName { get; set; } = null!;

        public virtual ICollection<ComponentsLog> ComponentsLogs { get; set; }
    }
}
