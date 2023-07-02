namespace DylansWebsite.Data;
public class Truck
{
    private string title;
    private string details;
    private string image;

    public Truck(string title = "", string details = "", string image = "")
    {
        this.title = title;
        this.details = details;
        this.image = image;
    }

    public string getTitle()
    {
        return this.title;
    }

    public string getDetails()
    {
        return this.details;
    }

    public string getImage()
    {
        return this.image;
    }
}
