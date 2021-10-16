using Microsoft.EntityFrameworkCore;

namespace Medical_video_.Models
{
    public class AreaContex : DbContext
    {
        public DbSet<Area> Area_ { get; set; }
        public AreaContex(DbContextOptions<AreaContex> options)
            : base(options)
        { 
            Database.EnsureCreated();
        }
    }
}