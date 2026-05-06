namespace _04._05.Models;

public class SocialMedia
{
    public int Id { get; set; }
    public string Icon { get; set; }
    public string Url { get; set; }
    public int TeamMemberId { get; set; }
    public TeamMember TeamMember { get; set; }
}
