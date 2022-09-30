using Microsoft.EntityFrameworkCore;
using WebApplication1.Entity;

namespace WebApplication1.Data
{
    public class ClientOptional : IClient
    {
        private readonly EntityData entityData;

        public ClientOptional(EntityData EntityData)
        {
            this.entityData = EntityData;
        }

        public void AddClient(string lastname, string firstname, string patronymic, string numberphone, string address, string description)
        {
            using (var db = entityData)
            {
                db.Clients.Add(new Client()
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
            using (var db = entityData)
            {
                for (int i = 0; i < db.Clients.Count(); i++)
                {
                    foreach (var client in db.Clients)
                    {
                        if (client.Id == id)
                        {
                            db.Clients.Remove(client);
                        }
                    }
                }
                db.SaveChanges();
            }
        }

        public IEnumerable<Client> GetAppClient(int id)
        {
            return this.entityData.Clients.Where(x => x.Id == id).ToList();
            
        }

        public void GetChangeClient(int id, string lastname, string firstname, string patronymic, string numberphone, string address, string description)
        {
            using (var db = entityData)
            {
                for (int i = 0; i < db.Clients.Count(); i++)
                {
                    foreach (var client in db.Clients)
                    {
                        if (client.Id == id)
                        {
                            client.LastName = lastname;
                            client.FirstName = firstname;
                            client.Patronymic = patronymic;
                            client.NumberPhone = numberphone;
                            client.Address = address;
                            client.Description = description;

                        }
                    }
                }
                db.SaveChanges();
            }
        }

        public IEnumerable<Client> GetClient()
        {
            return this.entityData.Clients;
        }

        public IEnumerable<Client> GetSearchClient(string qwery)
        {
            return this.entityData.Clients.Where(x => x.LastName.Contains(qwery)).ToList();
        }

    }
}


