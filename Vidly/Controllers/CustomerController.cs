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

        public ActionResult NewCustomer()
        {
            var memberShipTypes = _context.MemberShipTypes.ToList();

            ViewBag.MemberShipTypes = memberShipTypes;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var memberShipTypes = _context.MemberShipTypes.ToList();

                ViewBag.MemberShipTypes = memberShipTypes;
                ViewBag.Customer = customer;

                return View("NewCustomer", customer);
            }
            else
            {
                if (customer.Id == null)
                {
                    customer.MemberShipType =
                        _context.MemberShipTypes.Single(c => c.Id == customer.MemberShipTypeId);
                    _context.Customers.Add(customer);
                }
                else
                {
                    var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                    customerInDb.Name = customer.Name;
                    customerInDb.Bith = customer.Bith;
                    customerInDb.isSubscribed = customer.isSubscribed;
                    customerInDb.MemberShipTypeId = customer.MemberShipTypeId;
                    customerInDb.MemberShipType = customer.MemberShipType;
                }
                _context.SaveChanges();

                return RedirectToAction("CustomerList", "Customer");
            }
        }

        public ActionResult CustomerEdit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            var memberShipTypes = _context.MemberShipTypes.ToList();

            if (customer == null)
                return HttpNotFound();

            ViewBag.Customer = customer;
            ViewBag.MemberShipTypes = memberShipTypes;
            return View("NewCustomer", customer);
        }
    }
}