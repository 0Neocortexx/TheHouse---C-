using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities.Compras;

namespace Model.Mappings.Compras
{
    public class MercadoMap:IEntityTypeConfiguration<Mercado>
    {
        public void Configure(EntityTypeBuilder<Mercado> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
