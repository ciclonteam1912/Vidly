using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    [Table("CUSTOMERS")]
    public class Customer
    {
        [Column("ID")]
        public int Id { get; set; }

        [Column("NAME", TypeName = "NVARCHAR2")]
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Column("IS_SUBSCRIBED_TO_NEWSLETTER")]
        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Column("MEMBERSHIP_TYPE_ID")]
        public byte MembershipTypeId { get; set; }
    }
}