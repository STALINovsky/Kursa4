using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderedBook : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal OrderingPrice { get; set; }
        public string Author { get; set; }
        public Consumer Consumer { get; set; }
        public Order? Order { get; set; }

        public override string ToString()
        {
            return Id + ": " + Name + " " + Author;
        }
    }
}
