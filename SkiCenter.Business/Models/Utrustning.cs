namespace SkiCenter.Business.Models;

public class Utrustning
{
    public int UtrustningsId { get; set; }

    public string Exemplarnummer { get; set; } = string.Empty;

    public string Utrustningstyp { get; set; } = string.Empty;

    public string LangdStorlek { get; set; } = string.Empty;

    public string Status { get; set; } = string.Empty;
}