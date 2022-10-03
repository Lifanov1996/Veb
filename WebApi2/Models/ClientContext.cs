using Microsoft.EntityFrameworkCore;

namespace WebApi2.Models
{
    public class ClientContext :DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public ClientContext(DbContextOptions<ClientContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
