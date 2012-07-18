using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TodoListService.Web.Models;

namespace TodoListService.Web.Controllers
{
    public class TodoController : ApiController
    {
        List<TodoCategory> tags = new List<TodoCategory>
        {
            new TodoCategory {Id=Guid.NewGuid(), Name="Category 1"},
            new TodoCategory {Id= Guid.NewGuid(), Name="Category 2"}
        };
        TodoItem[] todos = new TodoItem[]
        {
            new TodoItem {Id=Guid.NewGuid(), Name="Do This First", Complete = false, CreateDate = DateTime.Now},
            new TodoItem {Id = Guid.NewGuid(), Name="Do This Next", Complete=true, CreateDate=DateTime.Now, DueDate=null}
        };

        public IEnumerable<TodoItem> GetAllTodos()
        {
            todos[1].Categories = tags;
            return todos;
        }
    }
}
