using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListService.Data.DataEntities
{
    public class TodoItemDE
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? DueDate { get; set; }
        public bool Complete { get; set; }
        public IList<TodoCategoryDE> Categories { get; set; }
    }
}
