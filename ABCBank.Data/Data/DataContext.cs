using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCBank.Data
{
    public class DataContext : IdentityDbContext<ApplicationUser, ApplicationRole, long>
    {

        public DataContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<ApplicationUser> AspNetUser { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

    }
}
