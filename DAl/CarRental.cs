using Microsoft.EntityFrameworkCore;

public partial class CarRentalContext : DbContext
{
    public CarRentalContext(DbContextOptions<CarRentalContext> options)
        : base("Name:ConnectionString")
    {

    }

    // DbSet for each entity
    public virtual DbSet<Admin> Admins { get; set; }
    public virtual DbSet<Car> Cars { get; set; }
    public virtual DbSet<Cost> Costs { get; set; }
    public virtual DbSet<Customer> Customers { get; set; }
    public virtual DbSet<Rental> Rentals { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}
