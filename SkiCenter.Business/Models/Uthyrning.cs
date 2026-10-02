namespace SkiCenter.Business.Models;

public class Uthyrning
{
    public int UthyrningsId { get; set; }
    public int BokningsradId { get; set; }

    public int UtrustningId { get; set; }

    public bool Utlamnad { get; set; }

    public bool Aterlamnad { get; set; }

    public string Betalningssatt { get; set; } = string.Empty;

    public string Status { get; set; } = string.Empty;
}