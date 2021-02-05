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
    [Table(BuyContract.TABLE_NAME)]
    public class Buy : EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(BuyContract.COL_ID)]
        public int Id { get; set; }
        [Column(BuyContract.COL_PRICE)]
        public decimal Price { get; set; }
        public virtual Book Book { get; set; }
        public virtual BookShop BookShop { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
