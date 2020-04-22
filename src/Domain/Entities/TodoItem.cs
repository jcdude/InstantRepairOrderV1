using InstantRepairOrderV1.Domain.Common;
using System;

namespace InstantRepairOrderV1.Domain.Entities
{
    public class TodoItem : AuditableEntity
    {
        public int Id { get; set; }

        public int ListId { get; set; }

        public string Title { get; set; }

        public string Note { get; set; }

        public bool Done { get; set; }

        public DateTime? Reminder { get; set; }


        public TodoList List { get; set; }
    }
}
