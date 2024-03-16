namespace GenshinImpactWiki.Data.Models;
public class Weapon
{
    public string? Name { get; set; }
    public string? Type { get; set; }
    public int? Rarity { get; set; }
    public int? BaseAttack { get; set; }
    public string? SubStat { get; set; }
    public string? PassiveName { get; set; }
    public string? PassiveDesc { get; set; }
    public string? Location { get; set; }
    public string? AscensionMaterial { get; set; }

    public string CureName(string? name)
    {
        name = name!.ToLower();
        return name.Replace(" ", "-");
    }
}
