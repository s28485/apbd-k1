namespace Kolokwium_1.DTOs;

public class PurchasedTicketDto
{
    public CustomerInfoDto Customer { get; set; }
    public DateTime PurchaseDate { get; set; }
    public TicketConcertInfoDto TicketConcert { get; set; }
    
}

public class CustomerInfoDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
}

public class TicketConcertInfoDto
{
    public float Price { get; set; }
    public TicketInfoDto Ticket { get; set; }
    public ConcertInfoDto Concert { get; set; }
}

public class TicketInfoDto
{
    public String SerialNumber { get; set; }
    public int SeatNumber { get; set; }
}

public class ConcertInfoDto
{
    public String Name { get; set; }
    public DateTime Date { get; set; }
}