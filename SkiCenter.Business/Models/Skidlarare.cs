namespace SkiCenter.Business.Models;

public class Skidlarare
{
    public int LarareId { get; set; }

    public string Namn { get; set; } = string.Empty;

    public string Epost { get; set; } = string.Empty;

    public string Telefon { get; set; } = string.Empty;

    public bool Aktiv { get; set; }
}