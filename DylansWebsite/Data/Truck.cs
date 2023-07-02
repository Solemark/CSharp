namespace DylansWebsite.Data;
public class Truck
{
    public string title { get; set; }
    public string details { get; set; }
    public string image { get; set; }

    public Truck(string title = "", string details = "", string image = "")
    {
        this.title = title;
        this.details = details;
        this.image = image;
    }
}
