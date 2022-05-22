namespace Model
{
    public class Emploee : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return Id + ": " + Name + " " + Surname;
        }
    }
}
