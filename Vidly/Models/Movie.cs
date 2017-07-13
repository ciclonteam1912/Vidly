using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Column("NUMBER_IN_STOCK")]
        [Range(1, 20)]
        [Display(Name = "Number in Stock")]
        public byte NumberInStock { get; set; }

        public Genre Genre { get; set; }

        [Column("GENRE_ID")]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        [Column("NUMBER_AVAILABLE")]
        public byte? NumberAvailable { get; set; }
    }
}