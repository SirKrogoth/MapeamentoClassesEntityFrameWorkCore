using MapeamentoClassesEntityFrameWorkCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MapeamentoClassesEntityFrameWorkCore.Data
{
    public class ProdutoMap : IEntityTypeConfiguration<Produtos>
    {
        public void Configure(EntityTypeBuilder<Produtos> builder)
        {
            builder.ToTable("Produto");

            builder.HasKey(p => p.ID);

            builder.Property(p => p.ID)
                .IsRequired()
                .UseSqlServerIdentityColumn();

            builder.Property(p => p.Descricao)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(p => p.CategoriaID)
                .IsRequired();

            builder.HasOne(p => p.Categoria)
                .WithMany(c => c.Produtos)
                .HasForeignKey(p => p.CategoriaID)
                .HasPrincipalKey(c => c.Id);
        }
    }
}