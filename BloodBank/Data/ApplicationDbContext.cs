using BloodBank.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BloodBank.Data
{
    public class ApplicationDbContext : IdentityDbContext<CustomUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Chat> Chats { get; set; }

        public DbSet<Groupblood> Groupbloods { get; set; }
    }
}
