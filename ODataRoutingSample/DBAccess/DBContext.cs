using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using ODataRoutingSample.Converters;
using ODataRoutingSample.DBAccess.Entities;

namespace ODataRoutingSample.DBAccess
{
    public class DBContext : DbContext
    {

        public DBContext()
        {
            this.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
            this.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Amount> TransactionAmounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DBContext).Assembly);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Replace default decimal type decimal(18, 2) for dynamic classes
            //optionsBuilder.ReplaceService<IRelationalTypeMappingSource, SqlDecimalServerTypeMappingSource>();
        }
    }
}
