using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    [Table("MOVIES")]
    public class Movie
    {
        [Column("ID")]
        public int Id { get; set; }

        [Column("NAME", TypeName = "NVARCHAR2")]
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Column("DATE_ADDED")]
        public DateTime DateAdded { get; set; }

        [Column("RELEASE_DATE")]
        public DateTime ReleaseDate { get; set; }

        [Column("NUMBER_IN_STOCK")]
        public byte NumberInStock { get; set; }

        public Genre Genre { get; set; }

        [Column("GENRE_ID")]
        public byte GenreId { get; set; }
    }
}