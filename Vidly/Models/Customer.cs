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

        public DateTime? Bith { get; set; }
    }
}