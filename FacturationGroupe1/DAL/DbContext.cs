using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FacturationGroupe1.Entity;

namespace FacturationGroupe1.DAL
{
    public class FactureContext : DbContext
    {
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderLine> orderLines { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<JournalAudit> journals { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<Invoice> invoices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var connectionString = "server=localhost;user=root;password=;database=bd_gestion_facturation";
            var ServerConnection = new MySqlServerVersion(new Version(5,7,36));
            optionsBuilder.UseMySql(connectionString, ServerConnection);
           // base.OnConfiguring(optionsBuilder);
        }
    }
}
