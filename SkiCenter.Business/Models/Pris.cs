namespace SkiCenter.Business.Models;

public class Pris
{
    public int PrisId { get; set; }

    public string Artikeltyp { get; set; } = string.Empty;

    public string Artikelbenamning { get; set; } = string.Empty;

    public decimal Belopp { get; set; }

    public decimal MomsSats { get; set; }

    public DateTime GiltigFran { get; set; }

    public DateTime GiltigTill { get; set; }
}