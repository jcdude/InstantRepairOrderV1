using IRO.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstantRepairOrderV1.Infrastructure.Persistence.Configurations
{
    class RepairOrderConfiguration : IEntityTypeConfiguration<RepairOrder>
    {
        public void Configure(EntityTypeBuilder<RepairOrder> builder)
        {
            builder.Property(t => t.RepairOrderNumber)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(t => t.ServiceAdvisor)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(t => t.UserVehicleId)
                .IsRequired();
        }
    }
}
