using ConsoleApp1.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Database
{
    public class MyBdContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public MyBdContext()
        {
            if (this.Database.CreateIfNotExists())
            {
                for (int i = 0; i < 20; i++)
                {
                    this.Users.Add(new Entities.User() { Firstname = "F" + i, Lastname = "L" + i });
                }

                this.SaveChanges();

                for (int i = 0; i < 5; i++)
                {
                    this.Roles.Add(new Entities.Role() { Name = "role" + i });
                }

                this.SaveChanges();
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasMany(x => x.Roles).WithMany();
            //modelBuilder.Entity<User>().HasKey(x => x.Superior);
            //modelBuilder.Entity<User>().HasRequired(x => x.Superior).WithRequiredPrincipal();
        }
    }
}
