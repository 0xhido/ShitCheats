namespace ShitCheats.Server.Models
{
  public class Command
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string CommandLine { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }
  }
}