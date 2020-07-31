using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShitCheats.Server.Data;
using ShitCheats.Server.Models;

namespace ShitCheats.Server.Controllers
{
  [Route("api/commands")]
  [ApiController]
  public class CommandsController : ControllerBase
  {
    private readonly ICommandRepo _repository;

    public CommandsController(ICommandRepo repository)
    {
      _repository = repository;
    }

    // GET /api/commands
    [HttpGet]
    public ActionResult<IEnumerable<Command>> GetAllCommands()
    {
      var commands = _repository.GetAllCommands();
      return Ok(commands);
    }

    // GET /api/commands/{id}
    [HttpGet("{id}")]
    public ActionResult<Command> GetCommandByID(int commandId)
    {
      var command = _repository.GetCommandByID(commandId);
      return Ok(command);
    }
  }
}