using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturationGroupe1.Entity
{
    public class OrderLine
    {
        [Key]
        public int IdLine { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public Order order { get; set; } = null;
        public Product Product { get; set; } = null;
    }
}
