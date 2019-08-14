using MapeamentoClassesEntityFrameWorkCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;

namespace MapeamentoClassesEntityFrameWorkCore.Application
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria");

            builder.HasKey(k => k.Id);

            builder.Property(c => c.Id)
                .IsRequired()
                .UseSqlServerIdentityColumn();

            builder.Property(c => c.Title)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(c => c.Descricao)
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            builder.HasMany(c => c.Produtos)
                .WithOne(p => p.Categoria)
                .HasForeignKey(fk => fk.CategoriaID)
                .HasPrincipalKey(c => c.Id);

        }
    }
}