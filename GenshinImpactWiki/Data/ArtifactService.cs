namespace GenshinImpactWiki.Data.Services;
using GenshinImpactWiki.Data.Models;
public class ArtifactService : DataService
{
    public async Task<Artifact[]?> getArtifacts(HttpClient http)
    {
        Artifact[]? weapons = null;
        loading = true;
        error = false;
        errormsg = "";
        try
        {
            weapons = await http.GetFromJsonAsync<Artifact[]>("https://api.genshin.dev/artifacts/all");
        }
        catch (Exception e)
        {
            errormsg = String.Format("{0}", e);
            error = true;
        }
        finally
        {
            loading = false;
        }
        return weapons;
    }
}
