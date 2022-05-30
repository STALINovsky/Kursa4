using System;
using System.Collections.Generic;

namespace Model
{
    public partial class Component
    {
        public Component()
        {
        }

        public int Id { get; set; }
        public string ComponentName { get; set; } = null!;
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int ManufacturerId { get; set; }
        public int ProviderId { get; set; }

        public Provider Provider { get; set; } = null!;
        public virtual Manufacturer Manufacturer { get; set; } = null!;
    }
}
