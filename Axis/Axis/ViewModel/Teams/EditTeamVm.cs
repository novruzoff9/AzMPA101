using System.ComponentModel.DataAnnotations;

namespace Axis.ViewModel.Teams;

public class EditTeamVm
{
    [MaxLength(50)]
    [MinLength(5)]
    [Required]
    public string FullName { get; set; }
    [Required]
    [MaxLength(10)]
    public string Position { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public IFormFile ImageUrl { get; set; }
}