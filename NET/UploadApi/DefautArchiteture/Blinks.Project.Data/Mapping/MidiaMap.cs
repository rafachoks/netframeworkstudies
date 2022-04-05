using Blinks.Project.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blinks.Project.Data.Mapping
{
    internal class MidiaMap : IEntityTypeConfiguration<Midia>
    {
        public void Configure(EntityTypeBuilder<Midia> builder)
        {
            builder.ToTable("TB_MIDIA");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(120)
                .HasColumnName("NM_MIDIA")
                .HasColumnType("varchar(120)");

            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(1000)
                .HasColumnName("DS_MIDIA")
                .HasColumnType("varchar(1000)");

            builder.Property(x => x.CreationDate)
                .IsRequired()
                .HasColumnName("CR_DATE")
                .HasColumnType("datetime");

            builder.Property(x => x.ModifiedDate)
                .HasColumnName("UP_DATE")
                .HasColumnType("datetime")
                .HasDefaultValue(DateTime.MinValue);

            builder.Property(x => x.IsActive)
                .HasColumnName("FL_ACTIVE")
                .HasColumnType("bit")
                .HasDefaultValue(DateTime.MinValue);
        }
    }
}
