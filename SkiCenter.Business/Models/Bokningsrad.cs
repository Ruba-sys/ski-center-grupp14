namespace SkiCenter.Business.Models;

public class Bokningsrad
{
    public int BokningsradId { get; set; }
    public int BokningId { get; set; }

    public string Typ { get; set; } = string.Empty;

    public int Antal { get; set; }

    public DateTime Startdatum { get; set; }

    public DateTime Slutdatum { get; set; }

    public decimal PrisVidBokning { get; set; }

    public decimal RabattBelopp { get; set; }

    public decimal MomsSats { get; set; }
}