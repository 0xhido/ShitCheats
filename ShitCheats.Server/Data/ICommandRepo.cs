using ShitCheats.Server.Models;
using System.Collections.Generic;

namespace ShitCheats.Server.Data
{
  public interface ICommandRepo
  {
    bool SaveChanges();
    IEnumerable<Command> GetAllCommands();
    Command GetCommandByID(int commandId);
    void CreateCommand(Command command);
    void UpdateCommand(Command command);
    void DeleteCommand(Command command);
  }
}