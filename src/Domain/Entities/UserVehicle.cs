using InstantRepairOrderV1.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace IRO.Domain.Entities
{
    public class UserVehicle : AuditableEntity
    {
        public Guid Id { get; set; }

        public int UserId { get; set; }

        public string Vin { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public string Year { get; set; }
        public string Mileage { get; set; }
    }
}
