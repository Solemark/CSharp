using System.Text.Json.Serialization;
namespace GenshinImpactWiki.Data.Models;
public class Artifact
{
    public string? name { get; set; }
    [JsonPropertyName("max_rarity")]
    public int? rarity { get; set; }
    [JsonPropertyName("1-piece_bonus")]
    public string? one_piece_bonus { get; set; }
    [JsonPropertyName("2-piece_bonus")]
    public string? two_piece_bonus { get; set; }
    [JsonPropertyName("4-piece_bonus")]
    public string? four_piece_bonus { get; set; }

    public Boolean checkArtifact(string? name)
    {
        switch (name)
        {
            case "Prayers for Destiny":
                return false;
            case "Prayers for Illumination":
                return false;
            case "Prayers for Wisdom":
                return false;
            case "Prayers to Springtime":
                return false;
            case "Sacrifieur to the Firmament":
                return false;
            default:
                return true;
        }
    }

    public String cureName(string? name)
    {
        name = name!.ToLower();
        name = name.Replace(" ", "-");
        name = name.Replace("'", "-");
        return name;
    }
}
