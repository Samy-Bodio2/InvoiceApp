using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturationGroupe1.Entity
{
    public class Client
    {
        [Key]
        public int IdClient { get; set; }
        public string ClientName { get; set; }
        public string ClientPosition { get; set; }
        public double ClientNumber { get; set; }
        public User user { get; set; } = null;
        public ICollection<Order> orders { get; set; } = null;
    }
}
