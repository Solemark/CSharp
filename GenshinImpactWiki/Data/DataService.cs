namespace GenshinImpactWiki.Data.Services;
public class DataService
{
    public bool loading { get; set; } = true;
    public bool error { get; set; } = false;
    public string errormsg { get; set; } = "";
}
