using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WepApiCore.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        public String Name { get; set; }
        public decimal Unitprice { get; set; }
        public int? availableQuantity { get; set; }
        public virtual ICollection<InvoiceProduct> InvoiceProducts { get; set; }
    }
}
