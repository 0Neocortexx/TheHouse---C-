using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities.CompraEntity;

namespace Model.Mappings.MapCompra
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
