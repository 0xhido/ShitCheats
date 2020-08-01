using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
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
    [HttpGet("{id}", Name = nameof(GetCommandByID))]
    public ActionResult<CommandReadDto> GetCommandByID(int id)
    {
      var command = _repository.GetCommandByID(id);

      if (command == null)
        return NotFound();

      return Ok(_mapper.Map<CommandReadDto>(command));
    }

    // POST /api/commands
    [HttpPost]
    public ActionResult<CommandReadDto> CreateCommand(CommandCreateDto commandCreateDto)
    {
      var command = _mapper.Map<Command>(commandCreateDto);

      _repository.CreateCommand(command);
      _repository.SaveChanges();

      var commandReadDto = _mapper.Map<CommandReadDto>(command);

      return CreatedAtRoute(nameof(GetCommandByID), new { id = command.Id }, commandReadDto);
    }

    // PUT /api/commands/{id}
    [HttpPut("{id}")]
    public ActionResult UpdateCommand(int id, CommandUpdateDto commandUpdateDto)
    {
      var commandFromRepo = _repository.GetCommandByID(id);

      if (commandFromRepo == null)
        return NotFound();

      _mapper.Map(commandUpdateDto, commandFromRepo);

      _repository.UpdateCommand(commandFromRepo);
      _repository.SaveChanges();

      return NoContent();
    }

    // PATCH /api/commands/{id}
    [HttpPatch("{id}")]
    public ActionResult PartialCommandUpdate(int id, JsonPatchDocument<CommandUpdateDto> patchDocument)
    {
      var commandFromRepo = _repository.GetCommandByID(id);

      if (commandFromRepo == null)
        return NotFound();

      var commandToPatch = _mapper.Map<CommandUpdateDto>(commandFromRepo);

      patchDocument.ApplyTo(commandToPatch, ModelState);
      if (!TryValidateModel(commandToPatch))
        return ValidationProblem(ModelState);

      _mapper.Map(commandToPatch, commandFromRepo);

      _repository.UpdateCommand(commandFromRepo);
      _repository.SaveChanges();

      return NoContent();
    }

    // DELETE /api/commands/{id}
    [HttpDelete("{id}")]
    public ActionResult DeleteCommand(int id)
    {
      var commandFromRepo = _repository.GetCommandByID(id);

      if (commandFromRepo == null)
        return NotFound();

      _repository.DeleteCommand(commandFromRepo);
      _repository.SaveChanges();

      return NoContent();
    }
  }
}