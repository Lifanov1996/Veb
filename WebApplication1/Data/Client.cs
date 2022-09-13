namespace WebApplication1.Data
{
    public class Client
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string NumberPhone { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }

        public Client (int id, string lastName, string firstName, string patronymic, string numberPhone, string address, string description)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            Patronymic = patronymic;
            NumberPhone = numberPhone;
            Address = address;
            Description = description;
        }

    }
}
