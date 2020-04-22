using InstantRepairOrderV1.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace InstantRepairOrderV1.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
