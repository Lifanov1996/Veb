using System.Linq;

namespace WebApplication1.Data
{
    public class Persone
    {
        private readonly List<Client> persone = new List<Client>() 
        {
                new Client(1, "Ivanov", "Ivan", "Ivanovich", "529-194", "Moskow", "Added persone"),
                new Client(2, "Ivanova", "Inna", "Sergeewna", "528-190", "Moskow", "Added clientes"),
                new Client(3, "Bondarow", "Adam", "Vladimirowich", "351-658", "Sankt- Peterburg", "Added persone"),
                new Client(4, "Eremina", "Lola", "Stepanowna", "495-123", "Rostow", "Added clientes"),
                new Client(5, "Kutuzow", "Daniil", "Artemowich", "495-999", "Rostow", "Added persone"),
                new Client(6, "Leonov", "Vadim", "Ivanovich", "495-845", "Sochi", "Added clientes"),
                new Client(7, "Loskutov", "Andrey", "Igorevich", "495-659", "Tomsk", "Added persone"),
                new Client(8, "Turusinov", "Sergey", "Petrovich", "529-445", "Omsk", "Added clientes")


        };

        public List<Client> GetClients()
        {
            return persone;
        }
          
        public List<Client> GetClientsAllId(int id)
        {
            return persone.Where(x => x.Id == id).ToList();
        }





    }
}
