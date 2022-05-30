using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime DeliveryDate { get; set; }

        public OrderStatus OrderStatus { get; set; }
    }   
}
