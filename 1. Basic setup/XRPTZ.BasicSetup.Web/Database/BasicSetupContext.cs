using Microsoft.EntityFrameworkCore;

namespace XRPTZ.BasicSetup.Web.Database;

internal class BasicSetupContext(DbContextOptions options) : DbContext(options);
