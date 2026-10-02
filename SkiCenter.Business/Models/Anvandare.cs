namespace SkiCenter.Business.Models;

public class Anvandare
{
    public int AnvandarId { get; set; }
    public int RollId { get; set; }

    public string Anvandarnamn { get; set; } = string.Empty;

    public string LosenordHash { get; set; } = string.Empty;

    public string Namn { get; set; } = string.Empty;

    public string Epost { get; set; } = string.Empty;

    public bool Aktiv { get; set; }
}