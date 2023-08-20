using Gift.Enums;

namespace Gift.Models;

[PrimaryKey(nameof(Id))]
public class Gift
{
    private int Id{ get; set; }
    public string Title { get; private set; }
    public DateTime DateCreated { get; private set; }
    public GiftStatus Status { get; private set; }
    public string Link { get; private set; }
    public decimal Price { get; private set; }
    public string Store { get; private set; } // Store dt
    public int EraId { get; private set; }
}