
using Microsoft.EntityFrameworkCore;

namespace ASPNetcoreEF
{
    public class EmpDbContext : DbContext
    {
        IConfiguration Configuration;
        public EmpDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("cs1"));
        }

        public DbSet<EmployeeModel> Employees { get; set; }
    }
}