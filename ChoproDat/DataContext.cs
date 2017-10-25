using Microsoft.EntityFrameworkCore;

namespace ChoproDat
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DataContext() { }

        public DbSet<Chore> Chores { get; set; }
    }
}
