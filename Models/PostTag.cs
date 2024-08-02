using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheCatWalk.Models;

public class PostTag
{
    public int Id { get; set; }
    [Required]
    [ForeignKey("Post")]
    public int PostId { get; set; }
    public Post Post { get; set; }
    [Required]
    [ForeignKey("Tag")]
    public int TagId { get; set; }
    public Tag Tag { get; set; }
}