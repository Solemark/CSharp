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
        string output = "";
        switch (name)
        {
            case "Tao":
                output = "Hu Tao";
                break;
            case "Shogun":
                output = "Raiden";
                break;
            case "Traveler":
                output = String.Format("{0}-{1}", name, vision);
                break;
            default:
                output = name;
                break;
        }
        return output;
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
        string output = "";
        switch (name)
        {
            case "kamisato-ayaka":
                output = "ayaka";
                break;
            case "kaedehara-kazuha":
                output = "kazuha";
                break;
            case "sangonomiya-kokomi":
                output = "kokomi";
                break;
            case "raiden-shogun":
                output = "raiden";
                break;
            case "kujou-sara":
                output = "sara";
                break;
            case "traveler":
                output = String.Format("traveler-{0}", vision!.ToLower());
                break;
            default:
                output = name;
                break;
        }
        return name;
    }

    public String cureBirthday(string? birthday)
    {
        string[] birthdays = birthday!.Split("-");
        return String.Format("{0}/{1}", birthdays[birthdays.Length - 1], birthdays[birthdays.Length - 2]);
    }
}

public class CharacterSubtype
{
    public string? name { get; set; }
    public string? unlock { get; set; }
    public string? description { get; set; }
}
