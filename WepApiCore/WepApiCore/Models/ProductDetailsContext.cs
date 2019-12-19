using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepApiCore.Models;

namespace WepApiCore.Models
{
    public class ProductDetailsContext :DbContext
    {
        public ProductDetailsContext(DbContextOptions<ProductDetailsContext> options):base(options)
        {

        }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<WepApiCore.Models.Customer> Customer { get; set; }
    }
}
