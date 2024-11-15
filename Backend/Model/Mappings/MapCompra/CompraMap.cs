using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities.CompraEntity;
using System.Reflection.Emit;

namespace Model.Mappings.MapCompra
{
    public class CompraMap :IEntityTypeConfiguration<Compra> {
        public void Configure(EntityTypeBuilder<Compra> builder) {

            builder.HasKey(e => e.Id);
           
            builder.HasOne(u => u.Usuario)
                .WithMany(u => u.Compras)
                .HasForeignKey(u => u.UsuarioId);

            builder.HasOne(l => l.ListaCompra)
                .WithMany()
                .HasForeignKey(l => l.ListaCompraId)
                .OnDelete(DeleteBehavior.SetNull); // Define o comportamento de exclusão para vínculo fraco

            builder.HasOne(m => m.Mercado)
                .WithMany()
                .HasForeignKey(m => m.MercadoId)
                .OnDelete(DeleteBehavior.SetNull); // Define o comportamento de exclusão para vínculo fraco
        }
    }
}
