namespace genshin_impact_wiki.Data.Models;
public class Character
{
    public string? name { get; set; }
    public string? title { get; set; }
    public string? vision { get; set; }
    public string? weapon { get; set; }
    public string? nation { get; set; }
    public string? affiliation { get; set; }
    public int? rarity { get; set; }
    public string? constellation { get; set; }
    public string? birthday { get; set; }
    public string? description { get; set; }
    public CharacterSubtype[]? skillTalents { get; set; }
    public CharacterSubtype[]? passiveTalents { get; set; }
    public CharacterSubtype[]? constellations { get; set; }
}

public class CharacterSubtype
{
    public string? name { get; set; }
    public string? unlock { get; set; }
    public string? description { get; set; }
}
