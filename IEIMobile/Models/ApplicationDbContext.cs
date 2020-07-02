using Microsoft.EntityFrameworkCore;

namespace IEIMobile.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {   

        }
    }
}