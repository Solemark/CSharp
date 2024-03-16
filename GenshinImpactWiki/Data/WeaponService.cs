namespace GenshinImpactWiki.Data.Services;
using GenshinImpactWiki.Data.Models;
public class WeaponService : DataService
{
    public async Task<Weapon[]?> getWeapons(HttpClient http)
    {
        Weapon[]? weapons = null;
        Loading = true;
        Error = false;
        Errormsg = "";
        try
        {
            weapons = await http.GetFromJsonAsync<Weapon[]>("https://api.genshin.dev/weapons/all");
        }
        catch (Exception e)
        {
            Errormsg = String.Format("{0}", e);
            Error = true;
        }
        finally
        {
            Loading = false;
        }
        return weapons;
    }
}
