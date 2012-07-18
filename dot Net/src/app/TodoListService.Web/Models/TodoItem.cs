using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoListService.Web.Models
{
    public class TodoItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? DueDate { get; set; }
        public bool Complete { get; set; }
        public IList<TodoCategory> Categories { get; set; }
    }
}