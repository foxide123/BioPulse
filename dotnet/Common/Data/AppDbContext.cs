using Microsoft.EntityFrameworkCore;


namespace dotnet.Common.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<SensorRaedings> SensorReadings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=hydroponicsystem.db");
        }

    }
}
