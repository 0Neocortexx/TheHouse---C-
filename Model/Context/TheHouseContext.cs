using Microsoft.EntityFrameworkCore;
using Model.Entities.Compras;
using Model.Entities.Entretenimento;
using Model.Entities.Financas;
using Model.Entities.Metas;
using Model.Entities.Usuario;
using System.Reflection;

namespace Model.Context {
    // Cria a classe TheHouseContext que herda da interface DbContext
    public class TheHouseContext : DbContext
    {
        public TheHouseContext(DbContextOptions<TheHouseContext> options) : base(options) { }
        
        // Inserindo as entidades que virarão tabela
        public DbSet<Visitas> Visitas { get; set; }
        public DbSet<ListaDeCompras> Compras { get; set; }
        public DbSet<FinancaDespesa> financaDespesa { get; set; }
        public DbSet<FinancaReceita> financaReceita { get; set; }
        public DbSet<Meta> meta { get; set; }
        public DbSet<Usuario> usuario { get; set; }

        // Criando o método obrigatório da interface DbContext
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Aplica todas as configurações de mapeamento da mesma assembly
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
