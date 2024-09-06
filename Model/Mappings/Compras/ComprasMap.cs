using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Model.Mappings.Compras
{
    public class ComprasMap :IEntityTypeConfiguration<Entities.Compras.ListaDeCompras> {
        public void Configure(EntityTypeBuilder<Entities.Compras.ListaDeCompras> builder) {
            builder.ToTable("ListaDeCompras");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Produto).HasMaxLength(100);
        }
    }
}
