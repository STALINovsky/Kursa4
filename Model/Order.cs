using Model.Enums;

namespace Model
{
    public class Order : BaseEntity
    {
        public DateTime CreateDate { get; set; }
        public Consumer Consumer { get; set; }
        public ICollection<OrderedBook> PurchaseProducts { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Emploee Emploee { get; set; }

        public override string ToString()
        {
            return Id + ": " + Consumer.Name + " " + Consumer.Surname;
        }
    }
}
