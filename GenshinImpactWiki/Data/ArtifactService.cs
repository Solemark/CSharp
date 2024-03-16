namespace GenshinImpactWiki.Data.Services;
using GenshinImpactWiki.Data.Models;
public class ArtifactService : DataService
{
    public async Task<Artifact[]?> GetArtifacts(HttpClient http)
    {
        Artifact[]? weapons = null;
        Loading = true;
        Error = false;
        Errormsg = "";
        try
        {
            weapons = await http.GetFromJsonAsync<Artifact[]>("https://api.genshin.dev/artifacts/all");
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
        return weapons;
    }
}
