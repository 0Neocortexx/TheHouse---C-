using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities.CompraEntity;

namespace Model.Mappings.MapCompra
{
    public class ItemListaCompraMap:IEntityTypeConfiguration<ItemListaCompra>
    {
        public void Configure(EntityTypeBuilder<ItemListaCompra> builder) 
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(e => e.ListaCompra)
                 .WithMany(prop => prop.ItensListaCompras)
                 .HasForeignKey(prop => prop.ListaCompraId);
        }
    }
}
