using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PurchasedComponent
    {
        public int Id { get; set; }
        public int ManufacturerId { get; set; }
        public string ComponentName { get; set; } = null!;
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }

        public string ManufacturerName { get; set; }
    }
}
