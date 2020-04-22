using IRO.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstantRepairOrderV1.Infrastructure.Persistence.Configurations
{
    class RepairOrderLaborConfiguration : IEntityTypeConfiguration<RepairOrderLabor>
    {
        public void Configure(EntityTypeBuilder<RepairOrderLabor> builder)
        {
            builder.Property(t => t.OpCode)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(t => t.OpCodeDesciption)
                .HasMaxLength(500)
                .IsRequired();
        }
    }
}
