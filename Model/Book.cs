namespace Model
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal OrderingPrice { get; set; }
        public string Author { get; set; }
        public int StockCount { get; set; }

        public override string ToString()
        {
            return Id + ": " + Name + " " + Description;
        }
    }
}
