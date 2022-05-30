using System;
using System.Collections.Generic;

namespace Kursa4
{
    public partial class CompanyView
    {
        public string DeliveryName { get; set; } = null!;
        public string ManufacturerName { get; set; } = null!;
        public string ComponentName { get; set; } = null!;
        public int ComponentsCount { get; set; }
        public decimal ComponentsPrice { get; set; }
        public string ProviderName { get; set; } = null!;
        public string? ProviderDescription { get; set; }
        public DateTime DateOfRegistration { get; set; }
    }
}
