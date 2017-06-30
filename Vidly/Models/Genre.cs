using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vidly.Models
{
    [Table("GENRES")]
    public class Genre
    {
        [Column("ID")]
        public byte Id { get; set; }

        [Column("NAME", TypeName = "NVARCHAR2")]
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}