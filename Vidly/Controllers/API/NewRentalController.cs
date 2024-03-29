﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.API
{
    public class NewRentalController : ApiController
    {
        public ApplicationDbContext _context { get; set; }

        public NewRentalController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [System.Web.Http.HttpPost]
        public IHttpActionResult createNewRentals(NewRentalDto newRental)
        //public IHttpActionResult createNewRentals(int CustomerId, int[] MovieIds)
        {
            Customer customer = _context.Customers.SingleOrDefault(c => c.Id == newRental.CustomerId);
            var movies = _context.Movies.Where(m => newRental.MovieIds.Contains(m.Id)).ToList();

            foreach (var movie in movies)
            {
                if (movie.NumAvailable == 0)
                {
                    return BadRequest();
                }
                movie.NumAvailable--;
                var rental = new Rental()
                {
                    Customer = customer,
                    DateRented= DateTime.Now,
                    Movie = movie
                };
                _context.Rentals.Add(rental);
                _context.SaveChanges();
            }
            return Ok();
        }
    }
}