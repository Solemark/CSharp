namespace GenshinImpactWiki.Data.Models;
public class Weapon
{
    public string? name { get; set; }
    public string? type { get; set; }
    public int? rarity { get; set; }
    public int? baseAttack { get; set; }
    public string? subStat { get; set; }
    public string? passiveName { get; set; }
    public string? passiveDesc { get; set; }
    public string? location { get; set; }
    public string? ascensionMaterial { get; set; }

    public String cureName(string? name)
    {
        name = name!.ToLower();
        name = name.Replace(" ", "-");

        return name;
    }
}
