using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactoryContext : DbContext
  {
    public DbSet<Machine> Machines { get; set; }
    public DbSet<Engineer> Engineers { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<EngineerMachine> EngineerMachine { get; set; }
    public DbSet<DepartmentEngineer> DepartmentEngineer { get; set; }
    public DbSet<MachineDepartment> MachineDepartment { get; set; }

    public FactoryContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}