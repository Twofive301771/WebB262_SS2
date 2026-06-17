using System.ComponentModel.DataAnnotations;
namespace SomaShareApp.Models;

public class Review
{
    public int ReviewID { get; set; }

    public int TransactionID { get; set; }
    public Transaction Transaction { get; set; } = null!;

    public string ReviewerID { get; set; } = string.Empty;
    public ApplicationUser Reviewer { get; set; } = null!;

    public string ReviewedUserID { get; set; } = string.Empty;
    public ApplicationUser ReviewedUser { get; set; } = null!;

    [Range(1, 5)]
    public int Rating { get; set; }

    [Required]
    public string Comment { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
