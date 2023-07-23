using Fullstack.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Fullstack.Api.Data
{
    public class FullstackDbContext : DbContext
    {
        public FullstackDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Product> products { get; set; }
    }
}
