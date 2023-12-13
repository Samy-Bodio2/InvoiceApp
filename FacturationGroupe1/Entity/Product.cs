using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturationGroupe1.Entity
{
    public class Product
    {
        [Key]
        public int IdProduct { get; set; }
        [Required]
        public string ReferenceProduct { get; set; } = null;
        [Required]
        public string ProductName { get; set; }
        [Required]
        public double BuyPrice { get; set; }
        public double SoldPrice { get; set; }
        public int TVA { get; set; }
        public int ActualStock { get; set; }
        public int SillStock { get; set; }

        public ICollection<OrderLine> orderLines { get; set; } = null;
        public Provider provider { get; set; } = null;
    }
}
