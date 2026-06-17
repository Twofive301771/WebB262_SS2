using System.ComponentModel.DataAnnotations;
namespace SomaShareApp.Models;

public class Textbook
{
    public int TextbookID { get; set; }
    [Required]
    public string Title { get; set; } = string.Empty;
    [Required]
    public string Author { get; set; } = string.Empty;

    public string? ISBN { get; set; }
    public string? Edition { get; set; }
    public string? Subject { get; set; }
    public string? Description { get; set; }

    public ICollection<Listing> Listings { get; set; } = new List<Listing>();
}
