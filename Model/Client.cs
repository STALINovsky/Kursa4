namespace Model
{
    public class Client : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumner { get; set; }

        public override string ToString()
        {
            return Id + ": " + Name + " " + Surname;
        }
    }
}
