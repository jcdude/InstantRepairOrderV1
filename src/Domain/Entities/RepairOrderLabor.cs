using System;
using System.Collections.Generic;
using System.Text;

namespace IRO.Domain.Entities
{
    public class RepairOrderLabor
    {
        public RepairOrderLabor()
        {
            RepairOrderParts = new HashSet<RepairOrderPart>();
        }

        public Guid RepairOrderLaborId { get; set; }
        public string OpCode { get; set; }
        public string OpCodeDesciption { get; set; }
        public RepairOrder RepairOrder { get; set; }

        public IEnumerable<RepairOrderPart> RepairOrderParts { get; set; }
    }
}
