namespace TheCatWalk.Models.DTOs;

public class PostDTO
{
    public int Id { get; set; }
    public Guid ImageId { get; set; }
    public string Caption { get; set; }
    public DateTime PostDate { get; set; }
    public int PhotographerId { get; set; }
    public UserProfile Photographer { get; set; }
    public bool Favorite { get; set; }
    public List<Comment> Comments { get; set; }
}