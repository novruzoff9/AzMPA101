using System.ComponentModel.DataAnnotations;

namespace Axis.Models;

public class Team : BaseEntity
{
    [MaxLength(50)]
    public string FullName { get; set; }
    [Required]
    public string Position { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}
