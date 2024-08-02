using System.ComponentModel.DataAnnotations;

namespace TheCatWalk.Models;

public class Post
{
    public int Id { get; set; }
    [Required]
    public Guid ImageId { get; set; }
    [Required]
    public string Caption { get; set; }
    [Required]
    public DateTime PostDate { get; set; }
    [Required]
    public int PhotographerId { get; set; }
    public UserProfile Photographer { get; set; }
    public bool Favorite { get; set; }
    public List<Comment> Comments { get; set; }

}