using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers.API
{
    public class RentalController : ApiController
    {
        private ApplicationDbContext _context;

        public RentalController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpGet]
        public IHttpActionResult GetRentals()
        {
            var rentals = _context.Rentals.
                Include(c => c.Movie).Include(c => c.Customer).
                Include(c=>c.Customer.MemberShipType).
                Include(c=>c.Movie.Genre).
                ToList().Select(Mapper.Map<Rental, RentalDto>);
            return Ok(rentals);
        }
    }
}
