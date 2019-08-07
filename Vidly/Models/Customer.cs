using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isSubscribed{ get; set; }
        public MemberShipType MemberShipType { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime? Bith { get; set; }

        [Display(Name = "Choose the membership type")]
        public byte? MemberShipTypeId { get; set; }
    }
}