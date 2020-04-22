using IRO.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstantRepairOrderV1.Infrastructure.Persistence.Configurations
{
    class RepairOrderPartConfiguration : IEntityTypeConfiguration<RepairOrderPart>
    {
        public void Configure(EntityTypeBuilder<RepairOrderPart> builder)
        {
            builder.Property(t => t.PartNumber)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(t => t.PartDesciption)
                .HasMaxLength(150)
                .IsRequired();
        }
    }
}
