namespace WebApplication1.Data
{
    public interface IClient
    {
        IEnumerable<Client> GetClient();

        void AddClient(string lastname, string firstname, string patronymic, string numberphone, string address, string description);

        IEnumerable<Client> GetAppClient(int id);

        IEnumerable<Client> GetSearchClient(string qwery);

        void GetDeletClient(int id);

        void GetChangeClient(int id, string lastname, string firstname, string patronymic, string numberphone, string address, string description);
    }
}
