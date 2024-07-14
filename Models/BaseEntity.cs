namespace PostgresAndEFCore.Models;

// BaseEntity class represents the common properties of all entities in the application
public class BaseEntity
{
  public int Id { get; set; }
  public int Status { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
}
