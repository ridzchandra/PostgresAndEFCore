using System.ComponentModel.DataAnnotations;

namespace PostgresAndEFCore.Models;

public class Driver : BaseEntity
{
  [Required]
  public int TeamId { get; set; }
  [Required]
  public string Name { get; set; } = string.Empty;
  [Required]
  public int RacingNumber { get; set; }
  [Required]
  public string FavouriteColor { get; set; } = string.Empty;
  public virtual Team? Team { get; set; }
  public virtual DriverMedia? DriverMedia { get; set; }
}
