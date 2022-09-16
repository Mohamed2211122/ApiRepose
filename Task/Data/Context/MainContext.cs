using Microsoft.EntityFrameworkCore;
using Task.Data.Models;

namespace Task.Data.Context
{
    public class MainContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Certification> Certifications => Set<Certification>();


        public MainContext(DbContextOptions<MainContext> options) : base(options)
        {

        }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Certification>().HasData(
            new Certification { Id = 1, Name = "Html" },
            new Certification { Id = 2, Name = "C#" },
            new Certification { Id = 3, Name = "JQ" },
             new Certification { Id = 4, Name = "JS" },
              new Certification { Id = 5, Name = "Core" }
              
            );


            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Malaak", CirtficatNum=8 },
                new User { Id = 2, Name = "Ahmed", CirtficatNum = 9 },
                new User { Id = 3, Name = "Ali", CirtficatNum = 3 },
                new User { Id = 4, Name = "Mazen", CirtficatNum = 2 },
                new User { Id = 5, Name = "James", CirtficatNum = 12 }
                );
        }

    }
}
