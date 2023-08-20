namespace Gift.Models;
[PrimaryKey(nameof(Id))]
public class Era
{
    private int Id { get; set; }
    public string Title { get; set; }
    public DateTime Year { get; set; }
    public int User { get; set; }
}