using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using DemoMVC.Models;


namespace MvcMovie.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}

        public DbSet<Person> Person { get; set; }
        public DbSet<DemoMVC.Models.Employee> Employee { get; set; } = default!;
    }
}

