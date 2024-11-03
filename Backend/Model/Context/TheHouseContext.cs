using Microsoft.EntityFrameworkCore;
using Model.Entities.CompraEntities;
using Model.Entities.CompraEntity;
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
        public DbSet<Compra> Compra { get; set; }
        public DbSet<ListaCompra> ListaCompra { get; set; }
        public DbSet<ItemListaCompra> ItemListaCompras { get; set; }
        public DbSet<Mercado> Mercado { get; set; }
        public DbSet<FinancaDespesa> financaDespesa { get; set; }
        public DbSet<FinancaReceita> financaReceita { get; set; }
        public DbSet<Meta> Meta { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        // Criando o método obrigatório da interface DbContext
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            // Aplica todas as configurações de mapeamento da mesma assembly
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override int SaveChanges() { 
            foreach (var entry in ChangeTracker.Entries().Where(e => e.State == EntityState.Added || e.State == EntityState.Modified)) 
            { 
                foreach (var property in entry.Properties) 
                { 
                    if (property.CurrentValue is DateTime dateTime && dateTime.Kind != DateTimeKind.Utc) 
                    { 
                        property.CurrentValue = dateTime.ToUniversalTime(); 
                    } 
                } 
            } return base.SaveChanges(); 
        }
    }
}
