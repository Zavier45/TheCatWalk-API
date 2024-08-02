using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheCatWalk.Models;

public class Comment
{
    public int Id { get; set; }
    [Required]
    public string Body { get; set; }
    [Required]
    [ForeignKey("UserProfile")]
    public int AuthorId { get; set; }
    public UserProfile Author { get; set; }
    [Required]
    [ForeignKey("Post")]
    public int PostId { get; set; }
    public Post Post { get; set; }
    public DateTime CommentDate { get; set; }
}