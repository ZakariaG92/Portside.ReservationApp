using System.Globalization;
using Microsoft.EntityFrameworkCore;
using Portside.Entities.Model;
using Portside.Persistance.Model;
using EF = Microsoft.EntityFrameworkCore;

namespace Portside.Persistance.DbContext;

public class DataBaseContext : EF.DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    
    
    public DataBaseContext(DbContextOptions<DataBaseContext> options): base(options)
    {
       
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>()
            .HasMany(c => c.Reservations)
            .WithOne(e => e.Customer)
            .IsRequired();
        

        modelBuilder.Entity<Customer>()
            .Property(c => c.Id)
            .HasDefaultValue(Guid.NewGuid().ToString());
        
        modelBuilder.Entity<Reservation>()
            .Property(c => c.Id)
            .HasDefaultValue(Guid.NewGuid().ToString());
        
    }

}