using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;

public class TigerTixContext : DbContext
{
    public DbSet<User> Users { get; set; }
}   