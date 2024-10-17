using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities.Financas;

namespace Model.Mappings.Financas {
    public class FinancaReceitaMap :IEntityTypeConfiguration<FinancaReceita> {

        public void Configure(EntityTypeBuilder<FinancaReceita> builder) {
            builder.ToTable("FinancaReceita");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
        }
    }
}
