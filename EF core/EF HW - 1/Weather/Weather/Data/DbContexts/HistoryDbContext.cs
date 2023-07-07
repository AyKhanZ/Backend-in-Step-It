using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Weather.Data.Models;

namespace Weather.Data.DbContexts;
public class HistoryDbContext : DbContext
{
    public DbSet<ForecastHistory> forecastHistories { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        ConfigurationBuilder builder = new();

        builder.AddJsonFile("appsettings.json");

        IConfigurationRoot config = builder.Build();

        var connectionString = config.GetConnectionString("History");

        optionsBuilder.UseSqlServer(connectionString);

        base.OnConfiguring(optionsBuilder);
    }
}
