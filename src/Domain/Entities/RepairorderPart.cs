using System;
using System.Collections.Generic;
using System.Text;

namespace IRO.Domain.Entities
{
    public class RepairOrderPart
    {
        public Guid RepairOrderLaborId { get; set; }
        public string PartNumber { get; set; }
        public string PartDesciption { get; set; }
        public RepairOrderLabor RepairOrderLabor { get; set; }
    }
}
