using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListService.Data.DataEntities;
using TodoListService.Data.Interfaces;
using DreamSeat;

namespace TodoListService.Data.DataAccessObjects
{
    public class CloudantTodoItemDAO : ITodoItemDAO
    {
        public IList<TodoItemDE> GetAllTodos()
        {
            var client = new CouchClient(
        }
    }
}
