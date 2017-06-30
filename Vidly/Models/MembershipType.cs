using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    [Table("MEMBERSHIP_TYPES")]
    public class MembershipType
    {
        [Column("ID")]
        public byte Id { get; set; }

        [Column("NAME", TypeName = "NVARCHAR2")]
        [StringLength(20)]
        public string Name { get; set; }

        [Column("SIGNUP_FEE")]
        public short SignUpFee { get; set; }

        [Column("DURATION_IN_MONTHS")]
        public byte DurationInMonths { get; set; }

        [Column("DISCOUNT_RATE")]
        public byte DiscountRate { get; set; }
    }
}