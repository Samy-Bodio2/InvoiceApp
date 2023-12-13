using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturationGroupe1.Entity
{
    public class Order
    {
        [Key]
        public int IdOrder { get; set; }
        public DateTime OrderDate { get; set; }
        public double OrderTotal { get; set; }
        public Client client { get; set; } = null;
        public Invoice invoice { get; set; } = null;
    }
}
