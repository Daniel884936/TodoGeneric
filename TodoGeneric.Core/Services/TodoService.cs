using System;
using System.Collections.Generic;
using System.Text;
using TodoGeneric.Core.Interfaces;
using TodoGeneric.Entities.Todo;

namespace TodoGeneric.Core.Services
{
    public class TodoService: BaseService<Todo>, ITodoService
    {
        private readonly ITodoRepository _todoRepository;
        public TodoService(ITodoRepository todoRepository) : base(todoRepository)
        {
            _todoRepository = todoRepository;
        }
    }
}
