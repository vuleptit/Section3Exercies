using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MemberShipType
    {
        public byte Id { get; set; }
        public byte Duration { get; set; }
        public short Price { get; set; }
        public byte Discount { get; set; }

        public string Name { get; set; }
    }
}