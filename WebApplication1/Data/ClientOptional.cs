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

        /// <summary>
        /// Добавление нового клиента
        /// </summary>
        /// <param name="lastname"></param>
        /// <param name="firstname"></param>
        /// <param name="patronymic"></param>
        /// <param name="numberphone"></param>
        /// <param name="address"></param>
        /// <param name="description"></param>
        public void GetAddClient(string lastname, string firstname, string patronymic, string numberphone, string address, string description)
        {
            using (var db = new EntityData())
            {
                db.Clients.Add(
                    new Client()
                    {
                        LastName = lastname,
                        FirstName = firstname,
                        Patronymic = patronymic,
                        NumberPhone = numberphone,
                        Address = address,
                        Description = description
                    });
                db.SaveChanges();
            }
        }

        public void GetDeletClient(int id)
        {
            using (var db = new EntityData())
            {
                db.Remove(Clients.Where(x => x.Id == id));

                db.SaveChanges();
            }
            
        }
    }
}
