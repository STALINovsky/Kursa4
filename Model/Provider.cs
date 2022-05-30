using System;
using System.Collections.Generic;

namespace Model
{
    public partial class Provider
    {
        public Provider()
        {
        }

        public int Id { get; set; }
        public string ProviderName { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<Component> Components { get; set; }

        public override string ToString()
        {
            return $"{Id}: {ProviderName}";
        }
    }
}
