using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheCatWalk.Models;

public class UserFavorite
{
    public int Id { get; set; }
    [Required]
    [ForeignKey("UserProfile")]
    public int UserId { get; set; }
    public UserProfile CurrentUser { get; set; }
    [Required]
    [ForeignKey("Post")]
    public int PostId { get; set; }
    public Post FavoritePost { get; set; }
}