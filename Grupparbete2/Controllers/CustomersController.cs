using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Grupparbete2.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Grupparbete2.Controllers
{
    public class CustomersController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var customers = DataManager.GetAllCustomers();
            ViewData["Customers"] = customers;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            DataManager.AddCustomer(customer);

            return RedirectToAction("Index");
        }
             
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


    }
}
