using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vidly.Models
{
    [Table("RENTALS")]
    public class Rental
    {
        [Column("ID")]
        public int Id { get; set; }

        public Customer Customer { get; set; }

        [Column("CUSTOMER_ID")]
        [Required]
        public int CustomerId { get; set; }

        public Movie Movie { get; set; }

        [Column("MOVIE_ID")]
        [Required]
        public int MovieId { get; set; }

        [Column("DATE_RENTED")]
        public DateTime DateRented { get; set; }

        [Column("DATE_RETURNED")]
        public DateTime? DateReturned { get; set; }
    }
}