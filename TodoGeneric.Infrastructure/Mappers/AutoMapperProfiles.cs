using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TodoGeneric.Core.DTOs.TodoDtos;
using TodoGeneric.Entities.Todo;

namespace TodoGeneric.Infrastructure.Mappers
{
    class AutoMapperProfiles: Profile
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
