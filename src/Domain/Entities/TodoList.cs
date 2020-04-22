using InstantRepairOrderV1.Domain.Common;
using System.Collections.Generic;

namespace InstantRepairOrderV1.Domain.Entities
{
    public class TodoList : AuditableEntity
    {
        public TodoList()
        {
            Items = new List<TodoItem>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Colour { get; set; }

        public IList<TodoItem> Items { get; set; }
    }
}
