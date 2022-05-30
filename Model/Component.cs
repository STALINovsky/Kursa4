using System;
using System.Collections.Generic;

namespace Model
{
    public partial class Component
    {
        public Component()
        {
            ComponentsLogs = new HashSet<ComponentsLog>();
        }

        public int Id { get; set; }
        public int ManufacturerId { get; set; }
        public string ComponentName { get; set; } = null!;
        public decimal Price { get; set; }
        public int Count { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Manufacturer Manufacturer { get; set; } = null!;
        public virtual ICollection<ComponentsLog> ComponentsLogs { get; set; }
    }
}
