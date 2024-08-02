using Microsoft.AspNetCore.Identity;

namespace TheCatWalk.Models.DTOs;

public class UserProfileDTO
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public bool IsAdmin { get; set; }
    public string IdentityUserId { get; set; }
    public IdentityUser IdentityUser { get; set; }
    public List<UserFavorite> UserFavorites { get; set; }
    public List<Comment> UserComments { get; set; }

}