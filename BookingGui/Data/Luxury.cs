namespace BookingGui.Data;
public class Luxury : Booking
{
    private bool securityAlarmCheck { get; set; }
    private bool poolMaintenance { get; set; }
    private double luxuryCost
    {
        get { return this.luxuryCost; }
        set
        {
            luxuryCost += securityAlarmCheck ? 50 : 0;
            luxuryCost += poolMaintenance ? 50 : 0;
        }
    }

    public Luxury(
        bool securityAlarmCheck = false,
        bool poolMaintenance = false,
        double gardenArea = 0,
        double gardenAreaCost = 0,
        double luxuryCost = 0,
        double numberOfWeeks = 0,
        double rooms = 0,
        double roomsCost = 0,
        string address = "",
        string bookingDate = "",
        string bookingID = "",
        string contactNumber = "",
        string propertyOwnerName = ""
    )
    {
        this.securityAlarmCheck = securityAlarmCheck;
        this.poolMaintenance = poolMaintenance;
        this.gardenArea = gardenArea;
        this.gardenAreaCost = gardenAreaCost;
        this.luxuryCost = luxuryCost;
        this.numberOfWeeks = numberOfWeeks;
        this.rooms = rooms;
        this.roomsCost = roomsCost;
        this.address = address;
        this.bookingDate = bookingDate;
        this.bookingID = bookingID;
        this.contactNumber = contactNumber;
        this.propertyOwnerName = propertyOwnerName;
    }
}
