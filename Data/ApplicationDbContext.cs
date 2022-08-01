using Microsoft.EntityFrameworkCore;
using WalletMVC.Models;

namespace WalletMVC.Data;

public class ApplicationDbContext : DbContext
{

    public DbSet<Category> Categories { get; set; }
    public DbSet<Transaction> Transactions { get; set; }

    public ApplicationDbContext(DbContextOptions options) : base(options){}
}