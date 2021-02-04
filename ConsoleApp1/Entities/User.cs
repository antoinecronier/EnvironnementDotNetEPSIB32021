using ConsoleApp1.Database.Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    [Table(UserContract.USER_TABLE)]
    public class User
    {
        private long id;
        private string firstname;
        private string lastname;
        private User superior;
        private List<Role> roles = new List<Role>();

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(UserContract.USER_COLUMN_ID)]
        public long Id { get => this.id; set => this.id = value; }

        [Column(UserContract.USER_COLUMN_FIRSTNAME)]
        [Required]
        public string Firstname { get => this.firstname; set => this.firstname = value; }

        [Column(UserContract.USER_COLUMN_LASTNAME)]
        [Required]
        public string Lastname { get => this.lastname; set => this.lastname = value; }

        [NotMapped]
        public string Fullname
        {
            get { return Firstname + "." + Lastname; }
        }

        public virtual List<Role> Roles { get => this.roles; private set => this.roles = value; }
       
        public virtual User Superior { get => this.superior; set => this.superior = value; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
