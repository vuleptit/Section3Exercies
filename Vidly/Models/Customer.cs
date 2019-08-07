using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Please enter the name field")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool isSubscribed{ get; set; }

        
        public MemberShipType MemberShipType { get; set; }

        [Min18YearsOldIfMember]
        [Display(Name = "Date of Birth")]
        public DateTime? Bith { get; set; }

        [Required(ErrorMessage = "Please choose the membership type")]
        [Display(Name = "Choose the membership type")]
        public byte MemberShipTypeId { get; set; }
    }
}