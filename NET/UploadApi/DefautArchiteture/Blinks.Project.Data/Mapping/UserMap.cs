using Blinks.Project.Domain.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blinks.Project.Data.Mapping
{
    internal class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnName("NM_USER")
                .HasColumnType("varchar(250");

            builder.Property(x => x.Email)
                .IsRequired()
                .HasColumnName("DS_EMAIL")
                .HasColumnType("varchar(100)");

            builder.Property(x => x.CreateTime)
                .IsRequired()
                .HasColumnName("DT_CREATE")
                .HasColumnType("Datetime")
                .HasDefaultValue(new DateTime());

            builder.Property(x => x.UpdateTime)
                .HasColumnName("DT_UPDATE")
                .HasColumnType("Datetime")
                .HasDefaultValue(new DateTime());

            builder.Property(x => x.IsActive)
                .HasColumnType("bit")
                .HasColumnName("ST_ACTIVE")
                .HasDefaultValue(false);
        }
    }
}
