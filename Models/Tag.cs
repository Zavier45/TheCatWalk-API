using System.ComponentModel.DataAnnotations;

namespace TheCatWalk.Models;

public class Tag
{
    public int Id { get; set; }
    [Required]
    public string TagName { get; set; }
}