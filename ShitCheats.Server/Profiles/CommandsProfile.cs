using AutoMapper;
using ShitCheats.Server.Dtos;
using ShitCheats.Server.Models;

namespace ShitCheats.Server.Profiles
{
  public class CommandsProfile : Profile
  {
    public CommandsProfile()
    {
      CreateMap<Command, CommandReadDto>();
    }
  }
}