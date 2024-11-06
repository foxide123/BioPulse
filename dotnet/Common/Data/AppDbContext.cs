using Microsoft.EntityFrameworkCore;
using dotnet.Features.SensorManagement.TemperatureSensor.Domain.Models;



namespace dotnet.Common.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<TemperatureSensor> TemperatureSensors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=hydroponicsystem.db");
        }

    }
}
