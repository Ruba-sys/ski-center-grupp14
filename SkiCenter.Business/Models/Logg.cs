namespace SkiCenter.Business.Models;

public class Logg
{
    public int LoggId { get; set; }
    public int AnvandarId { get; set; }

    public DateTime Tidpunkt { get; set; }

    public string Handelse { get; set; } = string.Empty;

    public string Objekttyp { get; set; } = string.Empty;

    public int ObjektId { get; set; }
}