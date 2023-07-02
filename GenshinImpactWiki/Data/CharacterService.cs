namespace GenshinImpactWiki.Data.Services;
using GenshinImpactWiki.Data.Models;
using System.Net.Http;
public class CharacterService : DataService
{
    public async Task<Character[]> getCharacters(HttpClient http)
    {
        Character[]? characters = null;
        loading = true;
        error = false;
        errormsg = "";
        try
        {
            characters = await http.GetFromJsonAsync<Character[]>("https://api.genshin.dev/characters/all");
        }
        catch (Exception e)
        {
            errormsg = "" + e;
            error = true;
        }
        finally
        {
            loading = false;
        }
        return characters!;
    }

    public async Task<Character> getCharacterDetails(HttpClient http, string? input)
    {
        Character? character = null;
        loading = true;
        error = false;
        errormsg = "";
        try
        {
            character = await http.GetFromJsonAsync<Character>("https://api.genshin.dev/characters/" + input);
        }
        catch (Exception e)
        {
            errormsg = "" + e;
            error = true;
        }
        finally
        {
            loading = false;
        }
        return character!;
    }
}
