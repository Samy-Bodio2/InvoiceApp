using FacturationGroupe1.Entity.ExtraType;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FacturationGroupe1.Entity
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public string Email { get; set; }
        public Role Status { get; set; } = Role.User;
        public JournalAudit journal { get; set; } = null;
        public ICollection<Client> clients { get; set; }
        public ICollection<Order> orders { get; set; }

    }
}
