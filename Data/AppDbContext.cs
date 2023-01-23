using blog.Models;
using Microsoft.EntityFrameworkCore;

namespace blog.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Role> Role { get; set; }
    }
}
