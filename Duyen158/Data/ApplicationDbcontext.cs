using Microsoft.EntityFrameworkCore;
using Duyen158.Models;
namespace Duyen158.Data
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }

        private readonly ApplicationDbcontext _context;

        

    }
}
