using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TodoGeneric.Core.DTOs.TodoDtos;
using TodoGeneric.Core.Interfaces;
using TodoGeneric.Entities.Todo;

namespace TodoGeneric.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : GenericController<Todo,TodoDto, TodoReadDto, TodoDto>
    {
        public TodoController(ITodoService todoService, IMapper mapper): base(todoService, mapper)
        {
        }
    }
}
