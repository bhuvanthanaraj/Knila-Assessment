using Knila_Assessment.Models;
using Microsoft.EntityFrameworkCore;

namespace Knila_Assessment.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book>Books { get; set; }



    }
}
