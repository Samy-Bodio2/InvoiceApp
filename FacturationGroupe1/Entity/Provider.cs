using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturationGroupe1.Entity
{
    public class Provider
    {
        [Key]
        public int IdProvier { get; set; }
        public string ProviderName { get; set; } = null;
        public string ProviderPosition { get; set; } = null;
        public ICollection<Product> Products { get; set; }
    }
}
