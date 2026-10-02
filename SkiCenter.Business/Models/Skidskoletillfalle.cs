namespace SkiCenter.Business.Models;

public class Skidskoletillfalle
{
    public int TillfalleId { get; set; }
    public int LarareId { get; set; }

    public DateTime Datum { get; set; }

    public TimeSpan Starttid { get; set; }

    public TimeSpan Sluttid { get; set; }

    public string Niva { get; set; } = string.Empty;

    public int MaxDeltagare { get; set; } = 10;

    public string Status { get; set; } = string.Empty;
}