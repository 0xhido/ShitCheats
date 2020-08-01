using AutoMapper;
using ShitCheats.Server.Dtos;
using ShitCheats.Server.Models;

namespace ShitCheats.Server.Profiles
{
  public class CommandsProfile : Profile
  {
    public CommandsProfile()
    {
      // Command -> CommandReadDto
      CreateMap<Command, CommandReadDto>();

      // CommandCreateDto -> Command
      CreateMap<CommandCreateDto, Command>();

      // CommandUpdateDto -> Command
      CreateMap<CommandUpdateDto, Command>();

      // Command -> CommandUpdateDto
      CreateMap<Command, CommandUpdateDto>();
    }
  }
}