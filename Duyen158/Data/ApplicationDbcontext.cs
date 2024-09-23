using Duyen158.Controllers;
using Microsoft.EntityFrameworkCore;

namespace Duyen158.Data{
    public class ApplicationDbcontext : DbContext
    {
       public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext>options) : base(options)
       {}
       public DbSet<Person> Person { get; set; }
    }
}