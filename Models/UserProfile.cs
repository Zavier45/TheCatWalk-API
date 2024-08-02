using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace TheCatWalk.Models;

public class UserProfile
{
    public int Id { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }

    public string Username { get; set; }
    [NotMapped]
    public string Email { get; set; }
    public bool IsAdmin { get; set; }
    [Required]
    public string IdentityUserId { get; set; }
    public IdentityUser IdentityUser { get; set; }
    public List<UserFavorite> UserFavorites { get; set; }
    public List<Comment> UserComments { get; set; }
    public string FullName
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
    }
}