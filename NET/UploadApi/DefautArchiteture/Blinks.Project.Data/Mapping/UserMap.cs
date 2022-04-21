﻿using Blinks.Project.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blinks.Project.Data.Mapping
{
    internal class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("TB_USER");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnName("NM_USER")
                .HasColumnType("varchar(250)");

            builder.Property(x => x.Email)
                .IsRequired()
                .HasColumnName("DS_EMAIL")
                .HasColumnType("varchar(100)");

            builder.Property(x => x.CreateDate)
                .IsRequired()
                .HasColumnName("DT_CREATE")
                .HasColumnType("Datetime")
                .HasDefaultValue(new DateTime());

            builder.Property(x => x.UpdateDate)
                .HasColumnName("DT_UPDATE")
                .HasColumnType("Datetime")
                .HasDefaultValue(new DateTime());

            builder.Property(x => x.IsActive)
                .HasColumnName("ST_ACTIVE")
                .HasColumnType("bit");

            builder.Property(x => x.Age)
                .HasColumnName("NR_AGE")
                .HasColumnType("Int")
                .IsRequired()
                .HasDefaultValue(0);
        }
    }
}
