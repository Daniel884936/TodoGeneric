using AutoMapper;
using TodoGeneric.Core.DTOs.TodoDtos;
using TodoGeneric.Entities.Todo;

namespace TodoGeneric.Infrastructure.Mappers
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Todo, TodoReadDto>();
            CreateMap<TodoReadDto, Todo>();
            CreateMap<TodoDto, Todo>();
            CreateMap<Todo, TodoDto>();
        }
    }
}
