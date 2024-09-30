using Microsoft.EntityFrameworkCore;
using Duyen158.Models;
using Duyen158.Controllers;
namespace Duyen158.Data
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }

        private readonly ApplicationDbcontext _context;

        }
}
