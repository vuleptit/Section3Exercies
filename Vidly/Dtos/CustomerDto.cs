﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int? Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public bool isSubscribed{ get; set; }


        //[Min18YearsOldIfMember]
        public DateTime? Bith { get; set; }

        [Required(ErrorMessage = "Please choose the membership type")]
        public byte MemberShipTypeId { get; set; }
    }
}