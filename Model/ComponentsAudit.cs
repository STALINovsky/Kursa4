using System;
using System.Collections.Generic;

namespace Model
{
    public partial class ComponentsAudit
    {
        public int Id { get; set; }
        public DateTime ComponentsAuditDate { get; set; }
        public int? ManufactureIdOld { get; set; }
        public int? ManufactureIdNew { get; set; }
        public string? ComponentNameOld { get; set; }
        public string? ComponentsNameNew { get; set; }
        public decimal? PriceOld { get; set; }
        public decimal? PriceNew { get; set; }
        public int? CountOld { get; set; }
        public int? CountNew { get; set; }
        public bool? IsDeletedOld { get; set; }
        public bool? IsDeletedNew { get; set; }
    }
}
