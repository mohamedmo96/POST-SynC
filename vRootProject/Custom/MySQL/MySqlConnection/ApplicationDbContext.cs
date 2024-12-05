using CoreLayer.Models.Business;
using CoreLayer.Models.ProductTechnology;
using CoreLayer.Models.ProductTechnology.ProductActions;
using Microsoft.EntityFrameworkCore;
using vRootProject.Custom.MySQL.BranchMysql.BranchMySqlModel;
using vRootProject.Custom.MySQL.ProductMysql.ModelsMySql;

public class ApplicationDbContext : DbContext
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        

    }



   // public DbSet<ProductMySql> Product { get; set; }
    public DbSet<BranchMy> branch { get; set; }
    public DbSet<Employee> employee { get; set; }
    public DbSet<Buddies> buddies { get; set; }
    public DbSet<EmployeeShift> employeeshift { get; set; }
    public DbSet<Product> product { get; set; }
    public DbSet<ProductVarint> productvarint { get; set; }
    public DbSet<Invoice> invoice { get; set; }
    public DbSet<InvoiceDetails> invoicedetails { get; set; }
    public DbSet<TransactionFlow> transactionflow { get; set; }
}
