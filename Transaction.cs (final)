using System.ComponentModel.DataAnnotations;
namespace SomaShareApp.Models;

public class Transaction
{
    public int TransactionID { get; set; }

    public int ListingID { get; set; }
    public Listing Listing { get; set; } = null!;

    public string BuyerID { get; set; } = string.Empty;
    public ApplicationUser Buyer { get; set; } = null!;

    public string SellerID { get; set; } = string.Empty;
    public ApplicationUser Seller { get; set; } = null!;

    [Range(1, 10000)]
    public decimal FinalPrice { get; set; }

    public string PaymentMethod { get; set; } = "Cash on Meetup";

    public string? MeetingLocation { get; set; }

    public string Status { get; set; } = "In Progress";

    public DateTime TransactionDate { get; set; } = DateTime.UtcNow;

    public ICollection<Review> Reviews { get; set; } = new List<Review>();
}
