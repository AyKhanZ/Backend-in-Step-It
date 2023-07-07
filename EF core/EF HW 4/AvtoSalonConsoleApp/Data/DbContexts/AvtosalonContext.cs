using AvtoSalonConsoleApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text.RegularExpressions;
namespace AvtoSalonConsoleApp.Data.DbContexts;
public class AvtosalonContext:DbContext
{
    public DbSet<Avto> Avtoes { get; set; }
    public DbSet<Avtosalon> Avtosalons { get; set; } 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        ConfigurationBuilder builder = new();

        builder.AddJsonFile("appsettings.json");

        IConfigurationRoot config = builder.Build();

        var connectionString = config.GetConnectionString("AvtoDb");

        optionsBuilder.UseSqlServer(connectionString);

        base.OnConfiguring(optionsBuilder);
    } 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Avto>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
            entity.Property(e => e.Mark).IsRequired();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.HasOne(d => d.Avtosalon).WithMany(p => p.Avtoes).HasForeignKey(d => d.AvtosalonId).IsRequired().OnDelete(DeleteBehavior.Cascade);
        }); 
        modelBuilder.Entity<Avtosalon>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name).IsRequired();
        } 
        );
    }
} 