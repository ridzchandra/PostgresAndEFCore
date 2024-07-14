using System.ComponentModel.DataAnnotations;

namespace PostgresAndEFCore.Models;

public class Team : BaseEntity
{
  [Required]
  public string Name { get; set; } = string.Empty;
  [Required]
  public int Year { get; set; } = 2024;
  public virtual ICollection<Driver> Drivers { get; set; } = new HashSet<Driver>();
}
