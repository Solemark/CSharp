namespace GenshinImpactWiki.Data.Models;
public class Character
{
    public string? Name { get; set; }
    public string? Title { get; set; }
    public string? Vision { get; set; }
    public string? Weapon { get; set; }
    public string? Nation { get; set; }
    public string? Affiliation { get; set; }
    public int? Rarity { get; set; }
    public string? Constellation { get; set; }
    public string? Birthday { get; set; }
    public string? Description { get; set; }
    public CharacterSubtype[]? SkillTalents { get; set; }
    public CharacterSubtype[]? PassiveTalents { get; set; }
    public CharacterSubtype[]? Constellations { get; set; }

    public string ShortenName(string name, string vision)
    {
        string[] names = name.Split(" ");
        name = names[^1];
        return name switch
        {
            "Tao" => "Hu Tao",
            "Shogun" => "Raiden",
            "Traveler" => string.Format("{0}-{1}", name, vision),
            _ => name,
        };
    }

    public string CheckTraveler(string? name)
    {
        if (name == "Traveler")
        {
            return "icon-big-lumine";
        }
        else
        {
            return "icon-big";
        }
    }

    public string CureName(string? name, string? vision)
    {
        name = name!.ToLower();
        name = name.Replace(" ", "-");
        return name switch
        {
            "kamisato-ayaka" => "ayaka",
            "kaedehara-kazuha" => "kazuha",
            "sangonomiya-kokomi" => "kokomi",
            "raiden-shogun" => "raiden",
            "kujou-sara" => "sara",
            "traveler" => string.Format("traveler-{0}", vision!.ToLower()),
            _ => name,
        };
    }

    public string CureBirthday(string? birthday)
    {
        string[] birthdays = birthday!.Split("-");
        return string.Format("{0}/{1}", birthdays[^1], birthdays[^2]);
    }
}

public class CharacterSubtype
{
    public string? Name { get; set; }
    public string? Unlock { get; set; }
    public string? Description { get; set; }
}
