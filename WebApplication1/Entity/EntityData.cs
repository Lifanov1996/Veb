using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Data;
using WebApplication1.AccountUser;

namespace WebApplication1.Entity
{
    public class EntityData : IdentityDbContext<User>
    {
        //public DbSet<Client> Clients { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDb;
        //                                DataBase=VebServer;
        //                                Trusted_Connection=True"
        //                                );
        //}

        public EntityData(DbContextOptions options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        
    }
}
