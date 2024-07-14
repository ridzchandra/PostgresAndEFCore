using System.ComponentModel.DataAnnotations;

namespace PostgresAndEFCore.Models;

public class DriverMedia : BaseEntity
{
  [Required]
  public int DriverId { get; set; }
  [Required]
  public string Media { get; set; } = string.Empty;

  public virtual Driver? Driver { get; set; }
}
