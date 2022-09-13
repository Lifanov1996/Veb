using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

namespace WebApplication1.Entity
{
    public class EntityData : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDb;
                                        DataBase=VebServer;
                                        Trusted_Connection=True"
                                        );
        }

    }
}
