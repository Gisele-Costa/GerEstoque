using GerEstoque.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerEstoque.Mapeamentos
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(c => c.CategoriaId);
            builder.Property(c => c.Nome).HasMaxLength(30).IsRequired();

            builder.HasMany(c => c.Produtos).WithOne(c => c.Categoria);

            builder.ToTable("Categorias");
        }
    }
}