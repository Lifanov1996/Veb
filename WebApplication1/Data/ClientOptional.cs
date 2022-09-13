using WebApplication1.Entity;

namespace WebApplication1.Data
{
    public class ClientOptional : EntityData
    {
        /// <summary>
        /// Переход на страницу клиента по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Client> GetClientsAllId(int id)
        {
            return Clients.Where(x => x.Id == id).ToList();
        }

        /// <summary>
        /// Поиск клиента по фамилии
        /// </summary>
        /// <param name="qwery"></param>
        /// <returns></returns>
        public List<Client> GetClientSearch(string qwery)
        {
            return Clients.Where(x => x.LastName.Contains(qwery)).ToList();
        }
    }
}
