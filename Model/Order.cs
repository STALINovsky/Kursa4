using Model.Enums;

namespace Model
{
    public class Order : BaseEntity
    {
        public DateTime CreateDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public Client Client { get; set; }
        public ICollection<OrderedBook> OrderedBooks { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Employee Emploee { get; set; }

        public override string ToString()
        {
            return Id + ": " + Client.Name + " " + Client.Surname;
        }
    }
}
