namespace SkiCenter.Business.Models;

public class Kund
{
    public int KundId { get; set; }

    public string KundTyp { get; set; } = string.Empty;

    public string Namn { get; set; } = string.Empty;

    public string Telefon { get; set; } = string.Empty;

    public string Epost { get; set; } = string.Empty;

    public string Adress { get; set; } = string.Empty;

    public decimal RabattProcent { get; set; }

    public decimal Kreditgrans { get; set; }

    public bool ForetagGodkant { get; set; }

    public string? Kommentar { get; set; }
}