using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities.Compras;

namespace Model.Mappings.Compras {
    public class ComprasMap :IEntityTypeConfiguration<ListaDeCompras> {
        public void Configure(EntityTypeBuilder<ListaDeCompras> builder) {
            builder.ToTable("ListaDeCompras");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Produto).HasMaxLength(100);
        }
    }
}
