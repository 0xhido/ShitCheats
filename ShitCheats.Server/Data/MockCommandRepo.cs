using System.Collections.Generic;
using ShitCheats.Server.Models;

namespace ShitCheats.Server.Data
{
  public class MockCommandRepo : ICommandRepo
  {
    public void CreateCommand(Command command)
    {
      throw new System.NotImplementedException();
    }

    public void DeleteCommand(Command command)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Command> GetAllCommands()
    {
      List<Command> commands = new List<Command>()
      {
        new Command
        {
          Id = 1,
          Name = "Mock Command Create",
          CommandLine = "mock.exe create command",
          Description = "This command creates a mock command",
          Category = "Mock Commands"
        },
        new Command
        {
          Id = 2,
          Name = "Mock Command Delete",
          CommandLine = "mock.exe delete command",
          Description = "This command deletes a mock command",
          Category = "Mock Commands"
        },
        new Command
        {
          Id = 3,
          Name = "Mock Command Update",
          CommandLine = "mock.exe update command",
          Description = "This command updates a mock command",
          Category = "Mock Commands"
        },
      };

      return commands;
    }

    public Command GetCommandByID(int commandId)
    {
      return new Command
      {
        Id = 1,
        Name = "Mock Command 1",
        CommandLine = "mock.exe create command",
        Description = "This command creates a mock command",
        Category = "Mock Commands"
      };
    }

    public bool SaveChanges()
    {
      throw new System.NotImplementedException();
    }

    public void UpdateCommand(Command command)
    {
      throw new System.NotImplementedException();
    }
  }
}