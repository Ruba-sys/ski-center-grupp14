namespace SkiCenter.Business.Models;

public class Boende
{
    public int BoendeId { get; set; }

    public string Benamning { get; set; } = string.Empty;

    public string Boendetyp { get; set; } = string.Empty;

    public int Kapacitet { get; set; }

    public string Status { get; set; } = string.Empty;
}