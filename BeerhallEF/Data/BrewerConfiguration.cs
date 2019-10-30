using BeerhallEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeerhallEF.Data
{
    internal class BrewerConfiguration : IEntityTypeConfiguration<Brewer>
    {
        public void Configure(EntityTypeBuilder<Brewer> builder)
        {
            builder.ToTable("Brewer");
            builder
                .Property(b => b.Name)
                .IsRequired(true)
                .HasMaxLength(50);

            builder
                .HasMany(b => b.Beers)
                .WithOne()
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}