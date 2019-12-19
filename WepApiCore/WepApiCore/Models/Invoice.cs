using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WepApiCore.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }
        [Required]
        [StringLength(50,MinimumLength =4)]
        public string Item { get; set; }
        public string Description { get; set; }
        [Required]
        public int Quantity { get; set; }
        public Nullable<decimal> Unitprice { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual ICollection<InvoiceProduct> InvoiceProducts { get; set; }

    }
}
