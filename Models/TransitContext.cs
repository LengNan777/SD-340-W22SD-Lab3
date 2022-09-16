using Microsoft.EntityFrameworkCore;

namespace SD_340_W22SD_Lab3.Models
{
    public partial class TransitContext : DbContext
    {
        public DbSet<Route> Routes { get; set; }
        public DbSet<ScheduledStop> ScheduledStops { get; set; }
        public DbSet<Stop> Stops { get; set; }
    }
}
