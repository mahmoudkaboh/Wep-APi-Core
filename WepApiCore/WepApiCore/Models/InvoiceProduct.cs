using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WepApiCore.Models
{
    public class InvoiceProduct
    {
        [Key]
        public int InvoiceProductID { get; set; }
        [ForeignKey("Invoice"), Column(Order = 0)]
        public int? InvoiceID { get; set; }
        [ForeignKey("Product"), Column(Order = 0)]
        public int? ProductID { get; set; }

        public virtual Invoice Invoice { get; set; }
        public virtual Product Product { get; set; }

        public int Quantity { get; set; }

    }
}
