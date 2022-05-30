using System;
using System.Collections.Generic;

namespace Model
{
    public partial class ComponentsLogsAudit
    {
        public int Id { get; set; }
        public DateTime ComponentsAuditDate { get; set; }
        public int? ComponentIdOld { get; set; }
        public int? ComponentIdNew { get; set; }
        public int? ProviderIdOld { get; set; }
        public int? ProviderIdNew { get; set; }
        public int? DeliveryIdOld { get; set; }
        public int? DeliveryIdNew { get; set; }
        public DateTime? DateOfRegistrationOld { get; set; }
        public DateTime? DateOfRegistrationNew { get; set; }
    }
}
