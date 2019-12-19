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
    public class ProductController : ControllerBase
    {
        private readonly ProductDetailsContext _context;

        public ProductController(ProductDetailsContext context)
        {
            _context = context;
        }

        // GET: api/Product
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return _context.Products;
        }

       
    }
}