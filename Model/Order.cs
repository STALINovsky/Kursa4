using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order : BaseEntity
    {
        public DateTime CreateDate { get; set; }
        public Consumer Consumer { get; set; }
        public ICollection<PurchaseProduct> PurchaseProducts { get; set;}
        public OrderStatus OrderStatus { get; set; }
        public Emploee Emploee { get; set; }
    }
}
