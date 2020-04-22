using InstantRepairOrderV1.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace IRO.Domain.Entities
{
    public class UserDmsLink : AuditableEntity
    {
        public Guid Id { get; set; }

        public int UserId { get; set; }

        public string DmsId { get; set; }

        public User User { get; set; }
    }
}
