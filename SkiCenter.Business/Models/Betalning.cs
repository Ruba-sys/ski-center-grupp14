namespace SkiCenter.Business.Models;

public class Betalning
{
    public int BetalningsId { get; set; }
    public int BokningId { get; set; }

    public decimal Belopp { get; set; }

    public DateTime Forfallodatum { get; set; }

    public DateTime Betalningsdatum { get; set; }

    public string Status { get; set; } = string.Empty;

    public string Betalningsmetod { get; set; } = string.Empty;
}