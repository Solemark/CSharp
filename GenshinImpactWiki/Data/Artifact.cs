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
}
