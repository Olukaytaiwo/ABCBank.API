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
        public DbSet<Account> UserIndividuals { get; set; }
        public DbSet<UserMerchant> UserMerchants { get; set; }
        public DbSet<UserSME> UserSMEs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        //public DbSet<NseProposal> NseProposals { get; set; }

    }
}
