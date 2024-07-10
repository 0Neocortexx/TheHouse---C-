using Microsoft.EntityFrameworkCore;
using Model.Entities.Entretenimento;
using Model.Mappings.Entretenimento;

namespace Model.Context
{
    public class TheHouseContext : DbContext
    {
        public TheHouseContext(DbContextOptions<TheHouseContext> options) : base(options) { }
        
        public DbSet<Visitas> visitas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new VisitasMap());
        }
    }
}
