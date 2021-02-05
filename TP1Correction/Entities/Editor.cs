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
    [Table(EditorContract.TABLE_NAME)]
    public class Editor : EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(EditorContract.COL_ID)]
        public int Id { get; set; }
        [Column(EditorContract.COL_NAME)]
        public string Name { get; set; }
        public virtual List<Book> Books { get; set; } = new List<Book>();
    }
}
