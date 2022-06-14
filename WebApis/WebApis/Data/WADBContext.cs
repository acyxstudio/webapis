using Microsoft.EntityFrameworkCore;
using WebApis.Models.Domain;   

namespace WebApis.Data
{
    public class WADBContext: DbContext
    {
        public WADBContext(DbContextOptions<WADBContext> options): base(options)
        {

        }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }

    }
}
