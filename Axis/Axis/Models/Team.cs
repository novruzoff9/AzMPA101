using System.ComponentModel.DataAnnotations;

namespace Axis.Models;

public class Team : BaseEntity
{
    [MaxLength(50, ErrorMessage = "Maximum 50 simvol ola biler")]
    [MinLength(3, ErrorMessage = "Minimum 3 simvol olmalidir")]
    public string FullName { get; set; }
    [Required(ErrorMessage = "Position mütləqdir")]
    public string Position { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}
