using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieRental.DAL;
using MovieRental.DAL.Services;
using MovieRental.DAL.Models;

namespace MovieRental.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private CustomerService _service;

        public CustomerController()
        {
            _service = new CustomerService();
        }

        [HttpPost]
        [Route("/Login")]
        public IActionResult CheckCustomer(Customer customer)
        {
            return Ok(_service.CheckCustomer(customer));
        }

        [HttpPost]

        public IActionResult Insert (Customer customer)
        {
            return Ok(_service.Insert(customer));
        }
    }
}
