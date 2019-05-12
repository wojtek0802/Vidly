using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        

        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customers = GetCustomers();
            var customer = customers.SingleOrDefault(c => c.Id == id);
            if(customer!=null)
                return View(customer);
            else
                return HttpNotFound();
        }

        private IEnumerable<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer {Name = "John Smith", Id=1},
                new Customer {Name ="Mary Williams", Id=2}
            };

            return customers;

        }
    }
}