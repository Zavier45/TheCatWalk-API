namespace TheCatWalk.Models.DTOs;

public class UserFavoriteDTO
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public UserProfileDTO User { get; set; }
    public int PostId { get; set; }
    public PostDTO FavoritePost { get; set; }
}