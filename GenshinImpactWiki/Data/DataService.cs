namespace GenshinImpactWiki.Data.Services;
public class DataService
{
    public bool Loading { get; set; } = true;
    public bool Error { get; set; } = false;
    public string Errormsg { get; set; } = "";
}
