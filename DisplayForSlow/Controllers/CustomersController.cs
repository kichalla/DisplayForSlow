using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DisplayForSlow.Models;

namespace DisplayForSlow.Controllers
{
    public class CustomersController : Controller
    {
        private static readonly List<Customer> _customers;

        static CustomersController()
        {
            _customers = Enumerable
                .Range(1, 500)
                .Select(i =>
                {
                    var customer = new Customer
                    {
                        Id = i,
                        FirstName = "FirstName" + i,
                        LastName = "LastName" + i
                    };

                    if (i % 2 == 0)
                    {
                        customer.Zipcode = i;
                    }

                    return customer;
                }).ToList();
        }

        // GET: Customers
        public IActionResult Index()
        {
            return View(_customers);
        }

    }
}
