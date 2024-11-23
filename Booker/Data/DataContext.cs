using Microsoft.EntityFrameworkCore;

namespace Booker.Data
{
    public class DataContext : DbContext
    {
        public DbSet<TextBook> Books { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

    }
}
