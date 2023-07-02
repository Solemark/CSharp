namespace GenshinImpactWiki.Data.Models;
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

    public string shortenName(string name, string vision)
    {
        string[] names = name.Split(" ");
        name = names[names.Length - 1];

        switch (name)
        {
            case "Tao":
                return "Hu Tao";
            case "Shogun":
                return "Raiden";
            case "Traveler":
                return name + "-" + vision;
            default:
                return name;
        }
    }

    public String checkTraveler(string? name)
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

    public String cureName(string? name, string? vision)
    {
        name = name!.ToLower();
        name = name.Replace(" ", "-");

        switch (name)
        {
            case "kamisato-ayaka":
                return "ayaka";
            case "kaedehara-kazuha":
                return "kazuha";
            case "sangonomiya-kokomi":
                return "kokomi";
            case "raiden-shogun":
                return "raiden";
            case "kujou-sara":
                return "sara";
            case "traveler":
                return "traveler" + "-" + vision!.ToLower();
            default:
                return name;
        }
    }

    public String cureBirthday(string? birthday)
    {
        string[] birthdays = birthday!.Split("-");
        birthday = birthdays[birthdays.Length - 1] + "/" + birthdays[birthdays.Length - 2];

        return birthday;
    }
}

public class CharacterSubtype
{
    public string? name { get; set; }
    public string? unlock { get; set; }
    public string? description { get; set; }
}
