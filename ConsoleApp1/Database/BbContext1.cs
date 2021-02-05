using ConsoleApp1.Entities;
using System;
using System.Data.Entity;

namespace ConsoleApp1.Database
{
    public class BbContext1 : DbContext
    {
        public DbSet<Role> Roles { get; set; }

        public BbContext1()
        {
            if (this.Database.CreateIfNotExists())
            {
                for (int i = 0; i < 20; i++)
                {
                    Role role = new Role() { Name = "role" + i };
                    this.Roles.Add(role);
                }

                this.SaveChanges();
            }
        }
    }
}