using Microsoft.EntityFrameworkCore;

namespace WEBapi.Models
{
    public class UsermContext : DbContext
    {
        public UsermContext(DbContextOptions<UsermContext> options)
            : base(options)
        {
        }

        public DbSet<Userm> Userm { get; set; } = null!;
        public DbSet<Device> Device { get; set; } = null!;
    }
}
