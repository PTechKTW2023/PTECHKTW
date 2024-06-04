using Microsoft.EntityFrameworkCore;

namespace recyclingAPI.Data
{
    public class DataContext : DbContext
    {

        public DbSet<CalendarEntry> CalendarEntries { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<WasteCollectionReportRow> WasteCollectionReportRows { get; set; }
        public DbSet<MonthlyWasteReport> MonthlyWasteReports { get; set; }
        public DbSet<WasteType> WasteTypes { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

    }
}
