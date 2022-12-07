
using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DataAccess
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
