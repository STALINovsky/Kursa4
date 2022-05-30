using System;
using System.Collections.Generic;

namespace Model
{
    public partial class ComponentsLog
    {
        public int Id { get; set; }
        public int ComponentId { get; set; }
        public int ProviderId { get; set; }
        public int DeliveryId { get; set; }
        public DateTime DateOfRegistration { get; set; }

        public virtual Component Component { get; set; } = null!;
        public virtual Delivery Delivery { get; set; } = null!;
        public virtual Provider Provider { get; set; } = null!;
    }
}
