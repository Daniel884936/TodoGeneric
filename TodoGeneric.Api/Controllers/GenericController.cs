using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoGeneric.Core.Entities;
using TodoGeneric.Core.Interfaces;

namespace TodoGeneric.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class GenericController<TEntity, TCreateDto, TReadDto, TUpdateDto> : ControllerBase 
        where TEntity : BaseEntity 
        where TCreateDto : class 
        where TReadDto : class
        where TUpdateDto : class
    {
        private readonly IBaseService<TEntity> _service;
        private readonly IMapper _mapper;


        public GenericController(IBaseService<TEntity> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var entities = _service.GetAll();
            var entitiesReadDto = _mapper.Map<IEnumerable<TReadDto>>(entities);
            return Ok(entitiesReadDto);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var entity = _service.GetById(id);
            var entityReadDto = _mapper.Map<TReadDto>(entity);
            return Ok(entityReadDto);
        }


    }
}
