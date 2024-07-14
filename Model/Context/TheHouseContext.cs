using Microsoft.EntityFrameworkCore;
using Model.Entities.Compras;
using Model.Entities.Entretenimento;
using Model.Entities.Financas;
using Model.Entities.Metas;
using Model.Mappings.Entretenimento;
using System.Reflection;

namespace Model.Context {
    public class TheHouseContext : DbContext
    {
        public TheHouseContext(DbContextOptions<TheHouseContext> options) : base(options) { }
        
        public DbSet<Visitas> visitas { get; set; }
        public DbSet<ListaDeCompras> listaDeCompras { get; set; }
        public DbSet<FinancaDespesa> financaDespesa { get; set; }
        public DbSet<FinancaReceita> financaReceita { get; set; }
        public DbSet<Meta> meta { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Aplica todas as configurações de mapeamento da mesma assembly
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
