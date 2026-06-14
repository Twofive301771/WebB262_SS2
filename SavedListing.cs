namespace SomaShareApp.Models;

public class SavedListing
{
    public string UserID { get; set; } = string.Empty;
    public ApplicationUser User { get; set; } = null!;

    public int ListingID { get; set; }
    public Listing Listing { get; set; } = null!;
}
