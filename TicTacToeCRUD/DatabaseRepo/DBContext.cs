using Microsoft.EntityFrameworkCore;
using TicTacToeCRUD.Models;

namespace TicTacToeCRUD.DatabaseRepo;

public class DBContext : DbContext
{
    public DBContext() : base() { }
    public DBContext(DbContextOptions options) : base(options) { }
    public DbSet<User> Users { get; set;}
}