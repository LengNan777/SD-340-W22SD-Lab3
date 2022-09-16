//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SD_340_W22SD_Lab3.Models;
namespace SD_340_W22SD_Lab3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SD_340_W22SD_Lab3.Models.Route>? Routes { get; set; }
        public DbSet<SD_340_W22SD_Lab3.Models.ScheduledStop>? ScheduledStops { get; set; }
        public DbSet<SD_340_W22SD_Lab3.Models.Stop>? Stops { get; set; }
    }
}
