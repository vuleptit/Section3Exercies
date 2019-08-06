using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Customer
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MemberShipType).ToList();

            List<Customer> customerList = customers;

            return View(customerList);
        }

        public ActionResult CustomerDetail(int id)
        {
            var customer = _context.Customers.Include(c => c.MemberShipType).SingleOrDefault(c => c.Id == id);
            if (customer == null) return HttpNotFound();

            ViewBag.Customer = customer;
            return View("CustomerDetail");
        }

        public ActionResult CustomerList()
        {
            var customers = _context.Customers.Include(c => c.MemberShipType).ToList();
            ViewBag.Customers = customers;

            return View("CustomerList");
        }
    }
}