using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WepApiCore.Models;

namespace WepApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ProductDetailsContext _context;

        public CustomerController(ProductDetailsContext context)
        {
            _context = context;
        }

        // GET: api/Customer
        [HttpGet]
        public IEnumerable<Customer> GetCustomer()
        {
            return _context.Customer;
        }

     
    }
}