using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Munafasa.Models.Tables;

namespace Munafasa.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ContractService>().Navigation(e => e.Service).AutoInclude();
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Service> Services { get; set; }
    public DbSet<Contract> Contracts { get; set; }
    public DbSet<ContractService> ContractServices { get; set; }
    public DbSet<ContractAttacments> ContractAttacments { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Owner> Owners { get; set; }
    public DbSet<Cheque> Cheques { get; set; }
    public DbSet<Request> Requests { get; set; }
    public DbSet<Technician> Technicians { get; set; }
    public DbSet<RequestImage> RequestImages { get; set; }
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    public DbSet<Moral> Morals { get; set; }
    public DbSet<ContactUs> Contacts { get; set; }
    public DbSet<Setting> Settings { get; set; }


}

