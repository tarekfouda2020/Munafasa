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
        modelBuilder.Entity<Contract>().Navigation(e => e.Owner).AutoInclude();
        modelBuilder.Entity<Contract>().Navigation(e => e.Cheques).AutoInclude();
        modelBuilder.Entity<Contract>().Navigation(e => e.Requests).AutoInclude();
        modelBuilder.Entity<Contract>().Navigation(e => e.Attacments).AutoInclude();

        modelBuilder.Entity<Client>().Navigation(e => e.Contract).AutoInclude();
        modelBuilder.Entity<Technician>().Navigation(e => e.TechnicianServices).AutoInclude();


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

