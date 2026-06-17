using System.ComponentModel.DataAnnotations;
namespace SomaShareApp.Models;

public class Offer
{
    public int OfferID { get; set; }

    public int ListingID { get; set; }
    public Listing Listing { get; set; } = null!;

    public string BuyerID { get; set; } = string.Empty;
    public ApplicationUser Buyer { get; set; } = null!;

    [Range(1, 10000)]
    public decimal OfferAmount { get; set; }

    public string Status { get; set; } = "Pending";

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
