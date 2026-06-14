using System.ComponentModel.DataAnnotations;
namespace SomaShareApp.Models;

public class WantedAd
{
    public int WantedAdID { get; set; }

    public string UserID { get; set; } = string.Empty;
    public ApplicationUser User { get; set; } = null!;

    [Required]
    public string Title { get; set; } = string.Empty;

    public string? Author { get; set; }
    public string? Edition { get; set; }
    public string? ISBN { get; set; }
    public string? Subject { get; set; }
    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
