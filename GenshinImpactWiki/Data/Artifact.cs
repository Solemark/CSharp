using System.Text.Json.Serialization;
namespace GenshinImpactWiki.Data.Models;
public class Artifact
{
    public string? Name { get; set; }
    [JsonPropertyName("max_rarity")]
    public int? Rarity { get; set; }
    [JsonPropertyName("1-piece_bonus")]
    public string? One_piece_bonus { get; set; }
    [JsonPropertyName("2-piece_bonus")]
    public string? Two_piece_bonus { get; set; }
    [JsonPropertyName("4-piece_bonus")]
    public string? Four_piece_bonus { get; set; }

    public bool CheckArtifact(string? name)
    {
        bool output = true;
        switch (name)
        {
            case "Prayers for Destiny":
                output = false;
                break;
            case "Prayers for Illumination":
                output = false;
                break;
            case "Prayers for Wisdom":
                output = false;
                break;
            case "Prayers to Springtime":
                output = false;
                break;
            case "Sacrifieur to the Firmament":
                output = false;
                break;
            default:
                output = true;
                break;
        }
        return output;
    }

    public string CureName(string? name)
    {
        name = name!.ToLower();
        name = name.Replace(" ", "-");
        name = name.Replace("'", "-");
        return name;
    }
}
