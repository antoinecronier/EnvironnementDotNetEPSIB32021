using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1.Entities.Contracts;

namespace TP1.Entities
{
    [Table(AuthorContract.TABLE_NAME)]
    public class Author : EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(AuthorContract.COL_ID)]
        public int Id { get; set; }
        [Column(AuthorContract.COL_FIRSTNAME)]
        public string Firstname { get; set; }
        [Column(AuthorContract.COL_LASTNAME)]
        public string Lastname { get; set; }
        public virtual List<Book> Books { get; set; } = new List<Book>();
    }
}
