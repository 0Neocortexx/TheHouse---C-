using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities.Financas;

namespace Model.Mappings.Financas {
    public class FinancaDespesaMap :IEntityTypeConfiguration<FinancaDespesa> {

        public void Configure(EntityTypeBuilder<FinancaDespesa> builder) {
            builder.ToTable("FinancaDespesa");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
        }
    }
}
