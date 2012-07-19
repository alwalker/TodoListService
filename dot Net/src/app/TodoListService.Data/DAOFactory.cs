using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListService.Data.DataAccessObjects;
using TodoListService.Data.Interfaces;

namespace TodoListService.Data.Common
{
    public class DAOFactory
    {
        public enum DataAccessType { Unknown = 0, Cloudant, RavenHQ, Postgres };

        private readonly DataAccessType _type;

        public DAOFactory(DataAccessType type)
        {
            _type = type;
        }

        public ITodoItemDAO GetTodoItemDAO()
        {
            switch (_type)
            {
                case DataAccessType.Cloudant:
                    return new CloudantTodoItemDAO();
                default:
                    return null;
            }
        }
    }
}
