using InstantRepairOrderV1.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace IRO.Domain.Entities
{
    public class User : AuditableEntity
    {
        public User()
        {
            UserDmsLinks = new HashSet<UserDmsLink>();
        }

        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Cell { get; set; }

        public ICollection<UserDmsLink> UserDmsLinks { get; private set; }
        public ICollection<UserVehicle> UserVehicles { get; private set; }
    }
}
