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
    public IEnumerable<Command> GetAllCommands()
    {
      return _context.Commands.ToList();
    }

    public Command GetCommandByID(int commandId)
    {
      return _context.Commands.FirstOrDefault(c => c.Id == commandId);
    }
  }
}