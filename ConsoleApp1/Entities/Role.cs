using System.Collections.Generic;

namespace ConsoleApp1.Entities
{
    public class Role
    {
        private long id;
        private string name;
        //private List<User> users = new List<User>();

        public long Id { get => this.id; set => this.id = value; }
        public string Name { get => this.name; set => this.name = value; }
        //public List<User> Users { get => this.users; private set => this.users = value; }
    }
}