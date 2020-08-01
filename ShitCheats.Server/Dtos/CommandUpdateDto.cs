using System.ComponentModel.DataAnnotations;

namespace ShitCheats.Server.Dtos
{
  public class CommandUpdateDto
  {
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