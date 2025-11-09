using Microsoft.EntityFrameworkCore;

namespace XRPTZ.BasicSetup.Web.Database;

public class BasicSetupContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
}
