using TodoGeneric.Core.Interfaces;
using TodoGeneric.Entities.Todo;
using TodoGeneric.Infrastructure.Data;

namespace TodoGeneric.Infrastructure.Repositories
{
    public class TodoRepository: BaseRepository<Todo>, ITodoRepository
    {
        public TodoRepository(TodoGenericContext context): base(context)
        {
        }

        //Methods releated with current entity
    }
}
