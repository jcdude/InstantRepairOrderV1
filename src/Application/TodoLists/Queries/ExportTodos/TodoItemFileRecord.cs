using InstantRepairOrderV1.Application.Common.Mappings;
using InstantRepairOrderV1.Domain.Entities;

namespace InstantRepairOrderV1.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
