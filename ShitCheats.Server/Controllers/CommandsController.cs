using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShitCheats.Server.Data;
using ShitCheats.Server.Dtos;
using ShitCheats.Server.Models;

namespace ShitCheats.Server.Controllers
{
  [Route("api/commands")]
  [ApiController]
  public class CommandsController : ControllerBase
  {
    private readonly ICommandRepo _repository;
    private IMapper _mapper;

    public CommandsController(ICommandRepo repository, IMapper mapper)
    {
      _repository = repository;
      _mapper = mapper;
    }

    // GET /api/commands
    [HttpGet]
    public ActionResult<IEnumerable<CommandReadDto>> GetAllCommands()
    {
      var commands = _repository.GetAllCommands();
      return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commands));
    }

    // GET /api/commands/{id}
    [HttpGet("{id}")]
    public ActionResult<CommandReadDto> GetCommandByID(int id)
    {
      var command = _repository.GetCommandByID(id);

      if (command == null)
        return NotFound();

      return Ok(_mapper.Map<CommandReadDto>(command));
    }
  }
}