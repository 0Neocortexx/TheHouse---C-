using Microsoft.EntityFrameworkCore;
using Model.Entities.Compras;
using Model.Entities.Financas;
using Model.Entities.GrupoMeta;
using Model.Entities.GrupoUsuario;
using Model.Entities.Visita;
using System.Reflection;

namespace Model.Context
{
    // Cria a classe TheHouseContext que herda da interface DbContext
    public class TheHouseContext : DbContext
    {
        public TheHouseContext(DbContextOptions<TheHouseContext> options) : base(options) { }
        
        // Inserindo as entidades que virarão tabela
        public DbSet<Visita> Visita { get; set; }
        public DbSet<ListaDeCompra> Compras { get; set; }
        public DbSet<FinancaDespesa> financaDespesa { get; set; }
        public DbSet<FinancaReceita> financaReceita { get; set; }
        public DbSet<Meta> Meta { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        // Criando o método obrigatório da interface DbContext
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasMany(c => c.Metas)
                .WithOne(o => o.Usuario)
                .HasForeignKey(o => o.UsuarioId);

            
            base.OnModelCreating(modelBuilder);

            // Aplica todas as configurações de mapeamento da mesma assembly
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
