using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturationGroupe1.Entity
{
    public class JournalAudit
    {
        [Key]
        public int IdAudit { get; set; }
        [Required]
        public DateTime ActionDate { get; set; }
        [Required]
        public string ActionRealisee { get; set; }
        [ForeignKey(nameof(JournalAudit))]
        public User? user { get; set; } = null;

    }
}
