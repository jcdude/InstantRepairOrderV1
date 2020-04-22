using InstantRepairOrderV1.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace IRO.Domain.Entities
{
    public class RepairOrder : AuditableEntity
    {
        public RepairOrder()
        {
            RepairOrderLabor = new HashSet<RepairOrderLabor>();
        }

        public Guid RepairOrderId { get; set; }

        public Guid UserVehicleId { get; set; }

        public string RepairOrderNumber { get; set; }

        public string ServiceAdvisor { get; set; }

        public UserVehicle UserVehicle { get; set; }

        public IEnumerable<RepairOrderLabor> RepairOrderLabor { get; set; }
    }
}
