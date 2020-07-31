using System.ComponentModel.DataAnnotations;

namespace ShitCheats.Server.Models
{
  public class Command
  {
    [Key]
    public int Id { get; set; }

    public string CreatorName { get; set; }

    [Required]
    [MaxLength(250)]
    public string Name { get; set; }

    [Required]
    public string CommandLine { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    [MaxLength(100)]
    public string Category { get; set; }
  }
}