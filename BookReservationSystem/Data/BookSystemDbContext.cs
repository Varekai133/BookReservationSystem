using Models;
using Microsoft.EntityFrameworkCore;

namespace Data {
    public class BookSystemDbContext : DbContext {
        public DbSet<Book> Books { get; set; }
        public DbSet<ReservedBook> ReservedBooks { get; set; }
        public DbSet<ReservationHistoryRecord> ReservationHistoryRecords { get; set; }

        public BookSystemDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}