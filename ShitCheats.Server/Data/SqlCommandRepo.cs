using System;
using System.Collections.Generic;
using System.Linq;
using ShitCheats.Server.Models;

namespace ShitCheats.Server.Data
{
  public class SqlCommandRepo : ICommandRepo
  {
    private readonly AppDbContext _context;

    public SqlCommandRepo(AppDbContext context)
    {
      _context = context;
    }

    public void CreateCommand(Command command)
    {
      if (command == null)
        throw new ArgumentNullException(nameof(command));

      _context.Commands.Add(command);
    }

    public void DeleteCommand(Command command)
    {
      if (command == null)
        throw new ArgumentNullException(nameof(command));

      _context.Commands.Remove(command);
    }

    public IEnumerable<Command> GetAllCommands()
    {
      return _context.Commands.ToList();
    }

    public Command GetCommandByID(int commandId)
    {
      return _context.Commands.FirstOrDefault(c => c.Id == commandId);
    }

    public bool SaveChanges()
    {
      return (_context.SaveChanges() >= 0);
    }

    public void UpdateCommand(Command command)
    {
      // Don't need to do anything....
    }
  }
}