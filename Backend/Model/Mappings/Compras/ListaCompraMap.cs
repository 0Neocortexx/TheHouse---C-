using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities.Compras;

namespace Model.Mappings.Compras
{
    public class ListaCompraMap:IEntityTypeConfiguration<ListaCompra>
    {
        public void Configure(EntityTypeBuilder<ListaCompra> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasOne(u => u.Usuario)
                .WithMany(u => u.ListaCompra)
                .HasForeignKey(u => u.UsuarioId);
        }
    }
}
