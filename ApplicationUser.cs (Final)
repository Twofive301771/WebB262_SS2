using Microsoft.AspNetCore.Identity;
namespace SomaShareApp.Models;

public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; } = string.Empty;
    public string Institution { get; set; } = string.Empty;
    public decimal TrustScore { get; set; } = 0.00m;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation Properties
    public ICollection<Listing> Listings { get; set; } = new List<Listing>();
    public ICollection<WantedAd> WantedAds { get; set; } = new List<WantedAd>();
    public ICollection<Offer> OffersMade { get; set; } = new List<Offer>();
    public ICollection<Transaction> TransactionsBought { get; set; } = new List<Transaction>();
    public ICollection<Transaction> TransactionsSold { get; set; } = new List<Transaction>();
    public ICollection<Review> ReviewsGiven { get; set; } = new List<Review>();
    public ICollection<Review> ReviewsReceived { get; set; } = new List<Review>();
    public ICollection<SavedListing> SavedListings { get; set; } = new List<SavedListing>();
}
