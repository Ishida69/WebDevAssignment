using eCommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Data
{
    public class UserAccountsContext: DbContext

    {
        public UserAccountsContext(DbContextOptions<UserAccountsContext> options) : base(options)
        {


        }

        public DbSet<UserAccount> Users { get; set; }


    }
}
