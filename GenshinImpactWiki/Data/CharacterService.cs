namespace GenshinImpactWiki.Data.Services;
using GenshinImpactWiki.Data.Models;
public class CharacterService : DataService
{
    public async Task<Character[]?> GetCharacters(HttpClient http)
    {
        Character[]? characters = null;
        Loading = true;
        Error = false;
        Errormsg = "";
        try
        {
            characters = await http.GetFromJsonAsync<Character[]>("https://api.genshin.dev/characters/all");
        }
        catch (Exception e)
        {
            Errormsg = string.Format("{0}", e);
            Error = true;
        }
        finally
        {
            Loading = false;
        }
        return characters;
    }

    public async Task<Character?> getCharacterDetails(HttpClient http, string? input)
    {
        Character? character = null;
        Loading = true;
        Error = false;
        Errormsg = "";
        try
        {
            character = await http.GetFromJsonAsync<Character>(string.Format("https://api.genshin.dev/characters/{0}", input));
        }
        catch (Exception e)
        {
            Errormsg = string.Format("{0}", e);
            Error = true;
        }
        finally
        {
            Loading = false;
        }
        return character;
    }
}
