namespace SkiCenter.Business.Models;

public class Bokning
{
    public int BokningsId { get; set; }
    public int KundId { get; set; }

    public int RegistreradAv { get; set; }

    public DateTime Bokningsdatum { get; set; }

    public DateTime Startdatum { get; set; }

    public DateTime Slutdatum { get; set; }

    public string Status { get; set; } = string.Empty;

    public decimal Totalbelopp { get; set; }

    public bool Avbestallningsskydd { get; set; }

    public string? Kommentar { get; set; }
}