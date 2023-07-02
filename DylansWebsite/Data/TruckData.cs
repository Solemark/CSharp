namespace DylansWebsite.Data;
public static class TruckData
{
    public static Truck[] getData()
    {
        return new Truck[] {
            new Truck("Small Truck", "Small truck details", "images/small_truck.webp"),
            new Truck("Medium Truck", "Medium truck details", "images/medium_truck.jpg"),
            new Truck("Big Truck", "Big truck details", "images/big_truck.webp"),
        };
    }
}
