using System;
using System.Collections.Generic;

namespace Model
{
    public partial class ComponentsView
    {
        public int Id { get; set; }
        public string ComponentName { get; set; } = null!;
        public string ManufacturerName { get; set; } = null!;
        public decimal Price { get; set; }
        public int Count { get; set; }
        public bool IsDeleted { get; set; }
    }
}
