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
    [Table(BookContract.TABLE_NAME)]
    public class Book : EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(BookContract.COL_ID)]
        public int Id { get; set; }
        [Column(BookContract.COL_NAME)]
        public string Name { get; set; }
        [Column(BookContract.COL_NBPAGE)]
        public int NbPage { get; set; }
        public virtual List<Author> Authors { get; set; } = new List<Author>();
        public virtual Editor Editor { get; set; }
        public virtual List<BookShop> BookShops { get; set; } = new List<BookShop>();
    }
}
