using System;
using System.Collections.Generic;

namespace Model
{
    public partial class Manufacturer
    {
        public Manufacturer()
        {
            Components = new HashSet<Component>();
        }

        public int Id { get; set; }
        public string ManufacturerName { get; set; } = null!;
        public bool IsDeleted { get; set; }

        public virtual ICollection<Component> Components { get; set; }
    }
}
