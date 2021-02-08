using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Entities;

namespace WebApplication1.Models
{
    public class UserVM
    {
        public User User { get; set; }
        public long? CurrentRoleId { get; set; }
        public List<long> RolesIds { get; set; }
        public List<Role> Roles { get; set; }
    }
}