namespace _04._05.Models;

public class TeamMember
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Description { get; set; }
    public string Position { get; set; }
    public string ImageUrl { get; set; }
    public List<SocialMedia> SocialMedias { get; set; }
}
