using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturationGroupe1.Entity
{
    public class Invoice
    {
        [Key]
        public int invoiceId { get; set; }
        [Required]
        public DateTime invoiceDate { get; set; }
        public double invoiceTotal { get; set; }
        public string invoicePDF { get; set; }
        [ForeignKey(nameof(Invoice))]
        public Order order { get; set; } = null;
    }
}
