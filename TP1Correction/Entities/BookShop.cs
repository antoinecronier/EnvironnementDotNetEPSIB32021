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
    [Table(BookShopContract.TABLE_NAME)]
    public class BookShop : EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(BookShopContract.COL_ID)]
        public int Id { get; set; }
        [Column(BookShopContract.COL_NAME)]
        public string Name { get; set; }
        public virtual List<Book> Books { get; set; } = new List<Book>();
    }
}
