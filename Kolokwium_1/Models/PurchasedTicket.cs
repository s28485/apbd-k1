using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Kolokwium_1.Models;

[Table("Purchased_Ticket")]
[PrimaryKey(nameof(CustomerId), nameof(TicketConcertId))]
public class PurchasedTicket
{
    [ForeignKey(nameof(TicketConcert))]
    public int TicketConcertId { get; set; }
    
    [ForeignKey(nameof(Customer))]
    public int CustomerId { get; set; }
    
    public DateTime PurchaseDate { get; set; }
    public TicketConcert TicketConcert { get; set; }
    public Customer Customer { get; set; }
}