namespace GenshinImpactWiki.Data.Services;
using GenshinImpactWiki.Data.Models;
using System.Net.Http;
public class WeaponService : DataService
{
    public async Task<Weapon[]?> getWeapons(HttpClient http)
    {
        Weapon[]? weapons = null;
        loading = true;
        error = false;
        errormsg = "";
        try
        {
            weapons = await http.GetFromJsonAsync<Weapon[]>("https://api.genshin.dev/weapons/all");
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
