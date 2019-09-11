using Microsoft.EntityFrameworkCore;

namespace DotNetCore2.Entities
{
    public class CityInfoContext : DbContext
    {
        public CityInfoContext(DbContextOptions options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<PointOfInterest> PointOfInterest { get; set; }
    }
}
