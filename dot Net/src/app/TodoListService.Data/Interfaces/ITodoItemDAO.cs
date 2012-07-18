using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListService.Data.DataEntities;

namespace TodoListService.Data.Interfaces
{
    public interface ITodoItemDAO
    {
        IList<TodoItemDE> GetAllTodos();
    }
}
