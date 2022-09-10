namespace WebApplication1.Data
{
    public class Client
    {
        public int Id { get; }
        public string LastName { get; }
        public string FirstName { get; }
        public string Patronymic { get; }
        public string NumberPhone { get; }
        public string Address { get; }
        public string Description { get; }

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
