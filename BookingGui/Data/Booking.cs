namespace BookingGui.Data;
public class Booking
{
    protected double gardenArea { get; set; } = 0.0;
    protected double gardenAreaCost { get; set; } = 0.0;
    protected double numberOfWeeks { get; set; } = 0.0;
    protected double rooms { get; set; } = 0.0;
    protected double roomsCost { get; set; } = 0.0;
    protected string address { get; set; } = "";
    protected string bookingDate { get; set; } = "";
    protected string bookingID { get; set; } = "";
    protected string contactNumber { get; set; } = "";
    protected string propertyOwnerName { get; set; } = "";

    public Booking(
        double gardenArea = 0,
        double gardenAreaCost = 0,
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
        this.gardenArea = gardenArea;
        this.gardenAreaCost = gardenAreaCost;
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
