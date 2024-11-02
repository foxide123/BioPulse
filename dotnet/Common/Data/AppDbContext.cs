using Microsoft.EntityFrameworkCore;


namespace dotnet.Common.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<TemperatureReadings> TemperatureReadings { get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=hydroponicsystem.db");
        }

    }
}
