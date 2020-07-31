using ShitCheats.Server.Models;
using System.Collections.Generic;

namespace ShitCheats.Server.Data
{
  public interface ICommandRepo
  {
    IEnumerable<Command> GetAllCommands();
    Command GetCommandByID(int commandId);
  }
}