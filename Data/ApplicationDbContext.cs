using Microsoft.EntityFrameworkCore;
using WalletMVC.Models;

namespace WalletMVC.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {}

    public DbSet<Category> Categories { get; set; }
}