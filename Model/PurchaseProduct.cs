using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PurchaseProduct : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int PurchaseCount { get; set; }
        public Consumer Consumer { get; set; }
        public Order? Order { get; set; }

        public override string ToString()
        {
            return Id + ": " + Name + " " + PurchaseCount;
        }
    }
}
